using Automatak.DNP3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Automatak.Simulator.DNP3.Components
{
    public partial class TemplateControl : UserControl
    {
        class Pair
        {
            public UInt16 first;
            public UInt16 second;
            public Pair(UInt16 first, UInt16 second)
            {
                this.first = first;
                this.second = second;
            }

            public override string ToString()
            {
                if (first == second)
                {
                    return first.ToString();
                }
                else
                {
                    return $"{first}-{second}";
                }
            }

            public static string ToString(IEnumerable<Pair> pairs)
            {
                return string.Join(";", pairs.Select(p => p.ToString()));
            }

            public static IEnumerable<Pair> Parse(string txt)
            {
                List<Pair> src = new List<Pair>();
                List<Pair> des = new List<Pair>();
                foreach (var single in txt.Split(';', ',', '|'))
                {
                    var parts = single.Split('-');
                    if (parts.Length == 1)
                    {
                        if (UInt16.TryParse(parts[0], out UInt16 index))
                        {
                            src.Add(new Pair(index, index));
                        }
                    }
                    else if (parts.Length == 2)
                    {
                        if (UInt16.TryParse(parts[0], out UInt16 first) && UInt16.TryParse(parts[1], out UInt16 second))
                        {
                            src.Add(new Pair(first, second));
                        }
                    }
                }

                foreach (var p in src.OrderBy(p => p.first))
                {
                    if (des.Count > 0 && (p.first == des.Last().first || des.Last().second == p.first + 1))
                    {
                        des.Last().second = Math.Max(des.Last().second, p.second);
                    }
                    else
                    {
                        des.Add(p);
                    }
                }

                return des;
            }
        }

        public TemplateControl()
        {
            InitializeComponent();
            Apply();
        }

        public void SetRecords(IEnumerable<EventRecord> records)
        {
            SuspendLayout();
            listViewMeas.SuspendLayout();
            listViewMeas.BeginUpdate();
            listViewMeas.Items.Clear();
            textBoxRange.Text = string.Empty;
            List<Pair> ranges = new List<Pair>();
            foreach (var row in records.OrderBy(r => r.index))
            {
                listViewMeas.Items.Add(CreateItem(row.index, row.clazz));
                if (ranges.Count > 0 && ranges.Last().second == row.index - 1)
                {
                    ranges[ranges.Count - 1].second = row.index;
                }
                else
                {
                    ranges.Add(new Pair(row.index, row.index));
                }
            }

            textBoxRange.Text = Pair.ToString(ranges);
            listViewMeas.EndUpdate();
            listViewMeas.ResumeLayout();
            ResumeLayout();
            CheckState();
        }

        public IEnumerable<EventRecord> GetRecords()
        {
            var list = new List<EventRecord>();
            foreach (ListViewItem item in listViewMeas.Items)
            {
                var pc = (PointClass)Enum.Parse(typeof(PointClass), item.SubItems[1].Text);
                UInt16 index = UInt16.Parse(item.SubItems[0].Text);
                list.Add(new EventRecord(index, pc));
            }

            return list;
        }

        void CheckState()
        {
            buttonEdit.Enabled = listViewMeas.SelectedIndices.Count > 0;
        }

        private void listViewMeas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckState();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var items = listViewMeas.SelectedItems;
            if (items.Count > 0)
            {
                using (var dialog = new TemplateItemDialog())
                {
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    {
                        var pointClass = dialog.SelectedPointClass.ToString();
                        listViewMeas.SuspendLayout();
                        foreach (ListViewItem item in items)
                        {
                            item.SubItems[1].Text = pointClass;
                        }
                        listViewMeas.ResumeLayout();
                    }
                }
            }
        }

        static ListViewItem CreateItem(UInt16 index, PointClass pc)
        {
            var strings = new String[] { index.ToString(), pc.ToString() };
            return new ListViewItem(strings);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRange.Text = string.Empty;
            listViewMeas.Items.Clear();
            CheckState();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void Apply()
        {
            Enabled = false;
            var oldRds = GetRecords().ToDictionary(r => r.index);
            var ranges = Pair.Parse(textBoxRange.Text).ToArray();
            List<EventRecord> newRds = new List<EventRecord>();
            foreach (var r in ranges)
            {
                for (UInt16 i = r.first; i <= r.second; i++)
                {
                    if (oldRds.ContainsKey(i))
                    {
                        newRds.Add(oldRds[i]);
                    }
                    else
                    {
                        newRds.Add(new EventRecord(i, PointClass.Class1));
                    }
                }
            }

            SetRecords(newRds);
            Enabled = true;
        }
    }
}
