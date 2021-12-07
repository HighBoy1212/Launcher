using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Launcher {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            // Display the open file dialog and see what the result is.
            DialogResult drOpenResult = ofdProgram.ShowDialog();
            if (drOpenResult == DialogResult.OK) {
                // File chosen. Copy path into text box, then enable the Start button.
                txtProgram.Text = ofdProgram.FileName;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            // Create a process to run the chosen program and start it
            Process pNewProcess = new Process();
            // Tell the path for the program to execute
            pNewProcess.StartInfo.FileName = txtProgram.Text;
            pNewProcess.Start();
            // Display process info in datagrid view
            int iNewRow = dgvProcesses.Rows.Add();
            DataGridViewRow dgvrNewRow = dgvProcesses.Rows[iNewRow];
            dgvrNewRow.Cells["ColFileName"].Value = Path.GetFileName(txtProgram.Text);
            dgvrNewRow.Cells["ColProcessID"].Value = pNewProcess.Id;
            dgvrNewRow.Cells["ColCPUTime"].Value = pNewProcess.TotalProcessorTime;
            dgvrNewRow.Cells["ColProcess"].Value = pNewProcess;
        }

        private void btnTerminate_Click(object sender, EventArgs e) {

        }
    }
}
