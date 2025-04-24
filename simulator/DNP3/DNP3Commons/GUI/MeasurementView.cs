using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Automatak.Simulator.DNP3.Commons
{
    public partial class MeasurementView : UserControl, IMeasurementObserver
    {
        MeasurementCollection collection = new MeasurementCollection();
        SortedDictionary<ushort, int> indexToRow = new SortedDictionary<ushort, int>();
        Dictionary<int, ushort> rowToIndex = new Dictionary<int, ushort>();

        public delegate void RowSelectionEvent(IEnumerable<UInt16> rows);

        public event RowSelectionEvent OnRowSelectionChanged;

        bool allowSelection = false;

        public MeasurementView()
        {
            InitializeComponent();
        }

        public bool AllowSelection
        {
            set
            {
                allowSelection = value;
            }
            get
            {
                return allowSelection;
            }
        }

        ListViewItem CreateItem(Measurement m)
        {
            string[] text = { m.Index.ToString(), m.Value, m.Flags, m.Timestamp };
            var item = new ListViewItem(text);
            return item;
        }

        void RefreshAllRows(IEnumerable<Measurement> rows)
        {
            try
            {
                this.listView.BeginUpdate();
                this.listView.Items.Clear();
                this.indexToRow.Clear();
                this.rowToIndex.Clear();
                int ri = 0;
                foreach (var m in rows)
                {
                    this.listView.Items.Add(CreateItem(m));
                    indexToRow[m.Index] = ri;
                    rowToIndex[ri] = m.Index;
                    ++ri;
                }
            }
            finally
            {
                this.listView.EndUpdate();
            }
        }

        void InsertOrUpdate(Measurement meas)
        {
            if (indexToRow.ContainsKey(meas.Index))
            {
                var row = indexToRow[meas.Index];
                this.listView.Items[row] = CreateItem(meas);
            }
            else
            {
                listView.Items.Add(CreateItem(meas));
                indexToRow[meas.Index] = listView.Items.Count - 1;
                rowToIndex[listView.Items.Count - 1] = meas.Index;
            }
        }

        void IMeasurementObserver.Refresh(IEnumerable<Measurement> rows)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => RefreshAllRows(rows)));
            }
            else
            {
                RefreshAllRows(rows);
            }
        }

        void IMeasurementObserver.Update(Measurement meas)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => InsertOrUpdate(meas)));
            }
            else
            {
                this.InsertOrUpdate(meas);
            }
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!allowSelection && e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }

        public IEnumerable<UInt16> SelectedIndices
        {
            get
            {
                foreach (int i in listView.SelectedIndices)
                {
                    yield return rowToIndex[i];
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.OnRowSelectionChanged != null)
            {
                OnRowSelectionChanged(SelectedIndices.ToArray());
            }
        }
    }
}
