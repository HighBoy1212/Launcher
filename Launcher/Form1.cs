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
using System.Threading;

namespace Launcher {
    public partial class Form1 : Form {
        // A boolean to tell whether we are still executing
        private bool bRunning = true;
        private Task tUpdateDGV = null;
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
            // Get the process selected in the data grid view
            if (dgvProcesses.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvrSelectedRow = dgvProcesses.SelectedRows[0];
                Process pSelected = (Process)dgvrSelectedRow.Cells["ColProcess"].Value;
                // Terminate the process
                pSelected.Kill();
                // Delete row from data grid view
                dgvProcesses.Rows.Remove(dgvrSelectedRow);
            }
        }

        private void vUpdateDGV()
        {
            // Loop forever, updating the datagrid view periodically
            while (bRunning)
            {
                // Wait for 0.5 seconds
                Thread.Sleep(500);
                // Loop through the rows in the DGV and update each one
                for (int iRow = 0; iRow < dgvProcesses.Rows.Count; iRow++)
                {
                    // Get the current row and its process
                    DataGridViewRow dgvrRow = dgvProcesses.Rows[iRow];
                    Process pCurrentProcess = (Process)dgvrRow.Cells["ColProcess"].Value;
                    // If the process has already exited, remove it from the dgv
                    // Otherwise, update its CPU time
                    if (pCurrentProcess.HasExited)
                    {
                        this.Invoke(new Action<DataGridViewRow>(dgvProcesses.Rows.Remove), dgvrRow);                           
                        iRow--;
                    }
                    else
                    {
                        // Update the CPU Time
                        dgvrRow.Cells["ColCPUTime"].Value = pCurrentProcess.TotalProcessorTime;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start a task to update the data grid view periodically
            // Other way.   Task.Run(new Action(vUpdateDGV));
            tUpdateDGV = Task.Run(vUpdateDGV);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the updating of the DGV
            bRunning = false;
            // Wait for the updating task to end
            tUpdateDGV.Wait();
            // Loop through the rows in the DGV and update ea
            for (int iRow = 0; iRow < dgvProcesses.Rows.Count; iRow++)
            {
                // Get the current row and its process
                DataGridViewRow dgvrRow = dgvProcesses.Rows[iRow];
                Process pCurrentProcess = (Process)dgvrRow.Cells["ColProcess"].Value;
                string strProcessName = (string)dgvrRow.Cells["ColFileName"].Value;
                DialogResult drYesorNo = MessageBox.Show("Would you like to terminate " + strProcessName + "?", "Terminate?", MessageBoxButtons.YesNo);
                if (drYesorNo == DialogResult.Yes)
                {
                    pCurrentProcess.Kill();
                    dgvProcesses.Rows.Remove(dgvrRow);
                    iRow--;
                }
            }
        }
    }
}
