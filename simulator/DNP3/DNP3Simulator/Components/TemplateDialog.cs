using Automatak.DNP3.Interface;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Automatak.Simulator.DNP3.Components
{
    partial class TemplateDialog : Form
    {
        public TemplateDialog(string alias, DatabaseTemplate template)
        {
            InitializeComponent();

            this.textBoxAlias.Text = alias;

            Configure(template);
        }

        public TemplateDialog(string alias)
        {
            InitializeComponent();

            this.textBoxAlias.Text = alias;
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public String SelectedAlias
        {
            get
            {
                return textBoxAlias.Text;
            }
        }

        public DatabaseTemplate ConfiguredTemplate
        {
            get
            {
                var template = new DatabaseTemplate(0);

                template.binaries = templateControlBinary.GetRecords().Select(rec => new BinaryRecord(rec.index)).ToList();
                template.doubleBinaries = templateControlDoubleBinary.GetRecords().Select(rec => new DoubleBinaryRecord(rec.index)).ToList();
                template.counters = templateControlCounter.GetRecords().Select(rec => new CounterRecord(rec.index)).ToList();
                template.frozenCounters = templateControlFrozenCounter.GetRecords().Select(rec => new FrozenCounterRecord(rec.index)).ToList();
                template.analogs = templateControlAnalog.GetRecords().Select(rec => new AnalogRecord(rec.index)).ToList();
                template.binaryOutputStatii = templateControlBOStatus.GetRecords().Select(rec => new BinaryOutputStatusRecord(rec.index)).ToList();
                template.analogOutputStatii = templateControlAOStatus.GetRecords().Select(rec => new AnalogOutputStatusRecord(rec.index)).ToList();


                return template;
            }
        }

        private void Configure(DatabaseTemplate template)
        {
            this.templateControlAnalog.SetRecords(template.analogs);
            this.templateControlAOStatus.SetRecords(template.analogOutputStatii);
            this.templateControlBinary.SetRecords(template.binaries);
            this.templateControlBOStatus.SetRecords(template.binaryOutputStatii);
            this.templateControlCounter.SetRecords(template.counters);
            this.templateControlDoubleBinary.SetRecords(template.doubleBinaries);
            this.templateControlFrozenCounter.SetRecords(template.frozenCounters);
        }

    }
}
