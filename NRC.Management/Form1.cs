using NRC.Connect;
using NRC.Management.Extensions;
using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRC.Management
{
    public partial class frmMain : Form
    {
        private NrcDevice device = null;
        public frmMain()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            device.RelayContact((int)nudContactRelayCode.Value);
        }

        private void btnGetDeviceInfo_Click(object sender, EventArgs e)
        {
            Task.Run(async() =>
            {
                try
                {
                    this.InvokeUI(() =>
                    {
                        device = new NrcDevice(new NrcConfig()
                        {
                            IP = cbIP.Text,
                            Port = int.Parse(tbPort.Text),
                            Username = tbUsername.Text,
                            Password = tbPassword.Text,
                        });
                        btnGetDeviceInfo.Enabled = false;
                    });
                   

                    dgvDeviceInfo.Rows.Clear();
                    var info= device
                        .GetDeviceInfo()
                        .ConvertToDictionary()
                        .ToList();

                    this.InvokeUI(() => info.ForEach(d => dgvDeviceInfo.Rows.Add(d.Key, d.Value)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                this.InvokeUI(() => {
                    btnGetDeviceInfo.Enabled = true;
                });
            });
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            device.RelayOn((int)nudOnRelayCode.Value);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            device?.RelayOff((int)nudOffRelayCode.Value);
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRelayGetValues_Click(object sender, EventArgs e)
        {
            var values = device
                    .GetRelaysValues()
                    .ToBoolArray(pad:device.Specifications.TotalOfRelay);
            lbRelayStatus.Items.Clear();
            for (int i = 0; i < device.Specifications.TotalOfRelay; i++)
            {
                lbRelayStatus.Items.Add($"Relay {i+1}: {values[i]}"); 
            }
        }

        private void btnGetSwInputStatus_Click(object sender, EventArgs e)
        {
            var values = device
                   .GetSwInputsValues()
                   .ToBoolArray(pad: device.Specifications.TotalOfSwitchInputs);
            lbSwInputsStatus.Items.Clear();
            for (int i = 0; i < device.Specifications.TotalOfSwitchInputs; i++)
            {
                lbSwInputsStatus.Items.Add($"SwInput {i + 1}: {values[i]}");
            }
        }

        private void btnGetHvInputStatus_Click(object sender, EventArgs e)
        {
            var values = device
                   .GetHvInputsValues()
                   .ToBoolArray(pad: device.Specifications.TotalOfHighVoltageInputs);
            lbHvInputsStatus.Items.Clear();
            for (int i = 0; i < device.Specifications.TotalOfHighVoltageInputs; i++)
            {
                lbHvInputsStatus.Items.Add($"HvInput {i + 1}: {values[i]}");
            }
        }

        private void btnGetAdcInputStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
