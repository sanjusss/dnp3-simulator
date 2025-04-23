using Automatak.DNP3.Interface;
using Automatak.Simulator.DNP3.API;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Automatak.Simulator.DNP3.Components
{
    partial class OutstationDialog : Form
    {
        readonly IDNP3Config config;
        readonly bool allowTemplateEdit;
        readonly OutstationStackConfig initialConfig;

        public OutstationDialog(IDNP3Config config, IOutstationModule module)
        {
            InitializeComponent();

            this.config = config;
            this.initialConfig = module.DefaultConfig;
            this.allowTemplateEdit = module.AllowTemplateEditing;
            this.textBoxID.Text = module.DefaultLogName;

            this.linkConfigControl.Configuration = initialConfig.link;

            if (allowTemplateEdit)
            {
                comboBoxTemplate.DataSource = config.Templates.Select(kv => kv.Key).ToList();
            }
            else
            {
                groupBoxDatabase.Enabled = false;
            }

            using (var dialog = new TemplateDialog("defaultTemplate"))
            {
                ApplyTemplate(dialog);
            }
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
                return textBoxID.Text;
            }
        }

        OutstationParams OutstationParameters
        {
            get
            {
                OutstationParams ret = new OutstationParams();
                ret.allowUnsolicited = this.checkBoxEnableUnsol.Checked;
                ret.maxControlsPerRequest = Decimal.ToByte(this.numericUpDownMaxControls.Value);
                ret.maxTxFragSize = Decimal.ToUInt16(this.numericUpDownMaxTxFrag.Value);
                ret.selectTimeout = TimeSpan.FromMilliseconds(Decimal.ToDouble(this.numericUpDownSelectTimeout.Value));
                ret.unsolicitedConfirmTimeout = TimeSpan.FromMilliseconds(Decimal.ToDouble(this.numericUpDownUnsolConfirmTimeout.Value));
                ret.solicitedConfirmTimeout = TimeSpan.FromMilliseconds(Decimal.ToDouble(this.numericUpDownSolConfirmTimeout.Value));
                ret.unsolicitedRetryPeriod = TimeSpan.FromMilliseconds(Decimal.ToDouble(this.numericUpDownUnsolicitedRetry.Value));
                return ret;
            }
        }

        public OutstationStackConfig Configuration
        {
            get
            {
                var oc = new OutstationStackConfig();
                oc.link = this.linkConfigControl.Configuration;

                oc.outstation.config = this.OutstationParameters;
                oc.outstation.buffer = this.eventBufferConfigControl1.Configuration;

                if (this.allowTemplateEdit)
                {
                    var templateId = this.comboBoxTemplate.SelectedItem.ToString();
                    var template = config.GetTemplateMaybeNull(templateId);
                    oc.databaseTemplate = (template == null) ? initialConfig.databaseTemplate : template;
                }
                else
                {
                    oc.databaseTemplate = initialConfig.databaseTemplate;
                }


                return oc;
            }
        }

        void CheckState()
        {
            if (this.allowTemplateEdit && comboBoxTemplate.SelectedValue == null)
            {
                this.buttonEdit.Enabled = false;
                this.buttonAdd.Enabled = false;
                this.toolStripStatusLabel1.Text = "You must select a device template";
            }
            else
            {
                this.buttonEdit.Enabled = true;
                this.buttonAdd.Enabled = true;
                this.toolStripStatusLabel1.Text = "";
            }

            DialogResult = DialogResult.None;
        }

        void OutstationDialog_Load(object sender, EventArgs e)
        {
            CheckState();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            using (var dialog = new TemplateDialog("template1", new DatabaseTemplate()))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ApplyTemplate(dialog);
                }
            }
        }

        private void comboBoxTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CheckState();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var alias = this.comboBoxTemplate.SelectedItem.ToString();
            var edited = config.GetTemplateMaybeNull(alias);

            if (edited != null)
            {
                using (var dialog = new TemplateDialog(alias, edited))
                {
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    {
                        ApplyTemplate(dialog);
                    }
                }

            }

            CheckState();
        }

        private void ApplyTemplate(TemplateDialog dialog)
        {
            DatabaseTemplate template = dialog.ConfiguredTemplate;
            staticResponseTypeControl1.Configure(template);
            eventResponseTypeControl1.Configure(template);
            config.AddTemplate(dialog.SelectedAlias, template);
            comboBoxTemplate.DataSource = config.Templates.Select(kvp => kvp.Key).ToList();
        }
    }
}
