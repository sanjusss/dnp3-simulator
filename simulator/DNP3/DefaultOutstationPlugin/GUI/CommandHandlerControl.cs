﻿using Automatak.DNP3.Interface;
using Automatak.Simulator.DNP3.Commons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Automatak.Simulator.DNP3.DefaultOutstationPlugin
{
    partial class CommandHandlerControl : UserControl
    {
        ProxyCommandHandler handler = null;
        IMeasurementLoader loader = null;

        public CommandHandlerControl()
        {
            InitializeComponent();

            this.comboBoxCode.DataSource = Enum.GetValues(typeof(CommandStatus));
            this.comboBoxDefaultCode.DataSource = Enum.GetValues(typeof(CommandStatus));
            this.comboBoxDefaultCode.SelectedItem = CommandStatus.SUCCESS;
            this.comboBoxDefaultCode.SelectedValueChanged += comboBoxDefaultCode_SelectedValueChanged;

            var clearHandlers = new ToolStripMenuItem("Clear");
            this.contextMenuStripHandlers.Items.Add(clearHandlers);
            clearHandlers.Click += clearHandlers_Click;

            var clearOperations = new ToolStripMenuItem("Clear");
            this.contextMenuStripOperations.Items.Add(clearOperations);
            clearOperations.Click += clearOperations_Click;
        }

        void clearOperations_Click(object sender, EventArgs e)
        {
            this.listBoxLog.Items.Clear();
        }

        void clearHandlers_Click(object sender, EventArgs e)
        {
            this.handler.ClearResponses();
            this.RepopulateList();
        }

        public void Configure(ProxyCommandHandler proxy, IMeasurementLoader loader)
        {
            this.handler = proxy;
            this.loader = loader;
            this.handler.BinaryCommandAccepted += handler_BinaryCommandAccepted;
            this.handler.AnalogCommandAccepted += handler_AnalogCommandAccepted;
            this.handler.DefaultStatus = (CommandStatus)this.comboBoxDefaultCode.SelectedItem;
            this.handler.Enabled = true;
        }

        void handler_AnalogCommandAccepted(double value, ushort index)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => handler_AnalogCommandAccepted(value, index)));
            }
            else
            {
                var output = String.Format("Accepted Analog: {0} - {1}", value, index);
                this.listBoxLog.Items.Add(output);
                if (checkBoxMapAnalog.Checked)
                {
                    var changes = new ChangeSet();
                    changes.Update(new AnalogOutputStatus(value, 0x01, DateTime.Now), index);
                    loader.Load(changes);
                }
            }
        }

        void handler_BinaryCommandAccepted(ControlRelayOutputBlock crob, ushort index)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => handler_BinaryCommandAccepted(crob, index)));
            }
            else
            {
                var output = String.Format("Accepted CROB: {0} - {1}", crob.code, index);
                this.listBoxLog.Items.Add(output);
                if (checkBoxMapBinary.Checked)
                {
                    var timestamp = DateTime.Now;

                    switch (crob.code)
                    {
                        case (ControlCode.LATCH_ON):
                            this.LoadSingleBinaryOutputStatus(true, index, timestamp);
                            break;
                        case (ControlCode.LATCH_OFF):
                            this.LoadSingleBinaryOutputStatus(false, index, timestamp);
                            break;
                        case (ControlCode.CLOSE_PULSE_ON):
                            this.LoadSingleBinaryOutputStatus(true, index, timestamp);
                            if (crob.onTime > 0)
                                this.LoadSingleBinaryOutputStatus(false, index, timestamp.AddMilliseconds(crob.onTime));
                            break;
                        case (ControlCode.TRIP_PULSE_ON):
                            this.LoadSingleBinaryOutputStatus(false, index, timestamp);
                            if (crob.onTime > 0)
                                this.LoadSingleBinaryOutputStatus(true, index, timestamp.AddMilliseconds(crob.onTime));
                            break;
                        case (ControlCode.PULSE_ON):
                            if (crob.onTime > 0)
                            {
                                this.LoadSingleBinaryOutputStatus(true, index, timestamp);
                                this.LoadSingleBinaryOutputStatus(false, index, timestamp.AddMilliseconds(crob.onTime));
                            }
                            break;
                        case (ControlCode.PULSE_OFF):
                            if (crob.offTime > 0)
                            {
                                this.LoadSingleBinaryOutputStatus(false, index, timestamp);
                                this.LoadSingleBinaryOutputStatus(true, index, timestamp.AddMilliseconds(crob.offTime));
                            }
                            break;
                    }
                }
            }
        }

        void LoadSingleBinaryOutputStatus(bool value, ushort index, DateTime timestamp)
        {
            var changes = new ChangeSet();
            changes.Update(new BinaryOutputStatus(value, 0x01, timestamp), index);
            loader.Load(changes);
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.handler.Enabled = this.checkBoxEnabled.Checked;
        }

        private IEnumerable<string> MakeHandlerStrings(string id, IEnumerable<KeyValuePair<ushort, CommandStatus>> pairs)
        {
            return pairs.Select(kvp => String.Format("{0} {1} -> {2}", id, kvp.Key, kvp.Value));
        }

        private void RepopulateList()
        {
            this.listBoxHandlers.SuspendLayout();
            this.listBoxHandlers.Items.Clear();
            this.listBoxHandlers.Items.AddRange(MakeHandlerStrings("BO", this.handler.BinaryResponses).ToArray());
            this.listBoxHandlers.Items.AddRange(MakeHandlerStrings("AO", this.handler.AnalogResponses).ToArray());
            this.listBoxHandlers.ResumeLayout();
        }

        private UInt16 SelectedIndex
        {
            get
            {
                return Decimal.ToUInt16(numericUpDownIndex.Value);
            }
        }

        private CommandStatus SelectedStatus
        {
            get
            {
                return (CommandStatus)this.comboBoxCode.SelectedValue;
            }
        }

        private void buttonAddBO_Click(object sender, EventArgs e)
        {
            this.handler.AddBinaryResponse(SelectedIndex, SelectedStatus);
            this.RepopulateList();
        }

        private void buttonAddAO_Click(object sender, EventArgs e)
        {
            this.handler.AddAnalogResponse(SelectedIndex, SelectedStatus);
            this.RepopulateList();
        }

        private void comboBoxDefaultCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (handler == null)
            {
                return;
            }

            this.handler.DefaultStatus = (CommandStatus)this.comboBoxDefaultCode.SelectedItem;
        }
    }
}
