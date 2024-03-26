using System;
using System.Management;
using System.Windows.Forms;

namespace AdapterCycler // Replace YourNamespace with your project's namespace
{
    public partial class Window : Form
    {
        private bool disableFirst = true;

        public Window()
        {
            InitializeComponent();
            adapterNameTextBox.Text = "Ethernet";
            adapterName2TextBox.Text = "WLAN";
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            CycleNetworkAdapters();
            MessageBox.Show("Cycle complete");
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            EnableAll();
            MessageBox.Show("Enabled all network adapters.");
        }

        void CycleNetworkAdapters()
        {
            string firstToDisable = adapterNameTextBox.Text;
            string secondToDisable = adapterName2TextBox.Text;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != null");
            foreach (ManagementObject networkAdapter in searcher.Get())
            {
                string adapterName = networkAdapter["NetConnectionId"] as string;

                if (adapterName == firstToDisable && disableFirst)
                {
                    networkAdapter.InvokeMethod("Disable", null);
                }
                
                if (adapterName == secondToDisable && disableFirst)
                {
                    networkAdapter.InvokeMethod("Enable", null);
                }

                if (adapterName == firstToDisable && !disableFirst)
                {
                    networkAdapter.InvokeMethod("Enable", null);
                }

                if (adapterName == secondToDisable && !disableFirst)
                {
                    networkAdapter.InvokeMethod("Disable", null);
                }
            }
            disableFirst = !disableFirst;
        }

        void EnableAll()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            foreach (ManagementObject networkAdapter in searcher.Get())
            {
                networkAdapter.InvokeMethod("Enable", null);
            }
        }
    }
}
