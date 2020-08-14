using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KPUAutoMacro.Dialog
{
    public partial class GetProcessDialog : Form
    {
        public Process Selected { get; private set; }

        public GetProcessDialog()
        {
            InitializeComponent();

            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    var icon = Icon.ExtractAssociatedIcon(process.MainModule.FileName);
                    this.icons.Images.Add(icon);

                    var item = new ListViewItem(process.ProcessName, this.icons.Images.Count - 1);
                    item.Tag = process;

                    this.processesView.Items.Add(item);
                }
                catch (Exception)
                { }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var selectedItems = this.processesView.SelectedItems;
            if(selectedItems.Count == 0)
                return;

            this.Selected = selectedItems[0].Tag as Process;
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
