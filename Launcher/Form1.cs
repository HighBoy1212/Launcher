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

        }

        private void btnTerminate_Click(object sender, EventArgs e) {

        }
    }
}
