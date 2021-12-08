namespace Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxStart = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.gbxMonitor = new System.Windows.Forms.GroupBox();
            this.dgvProcesses = new System.Windows.Forms.DataGridView();
            this.ColFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCPUTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.ofdProgram = new System.Windows.Forms.OpenFileDialog();
            this.gbxStart.SuspendLayout();
            this.gbxMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStart
            // 
            this.gbxStart.Controls.Add(this.btnStart);
            this.gbxStart.Controls.Add(this.btnBrowse);
            this.gbxStart.Controls.Add(this.txtProgram);
            this.gbxStart.Controls.Add(this.lblProgram);
            this.gbxStart.Location = new System.Drawing.Point(12, 12);
            this.gbxStart.Name = "gbxStart";
            this.gbxStart.Size = new System.Drawing.Size(460, 91);
            this.gbxStart.TabIndex = 0;
            this.gbxStart.TabStop = false;
            this.gbxStart.Text = "Start";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(192, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(379, 34);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(6, 36);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(367, 20);
            this.txtProgram.TabIndex = 1;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(7, 20);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(46, 13);
            this.lblProgram.TabIndex = 0;
            this.lblProgram.Text = "Program";
            // 
            // gbxMonitor
            // 
            this.gbxMonitor.Controls.Add(this.dgvProcesses);
            this.gbxMonitor.Controls.Add(this.btnTerminate);
            this.gbxMonitor.Location = new System.Drawing.Point(12, 109);
            this.gbxMonitor.Name = "gbxMonitor";
            this.gbxMonitor.Size = new System.Drawing.Size(460, 240);
            this.gbxMonitor.TabIndex = 1;
            this.gbxMonitor.TabStop = false;
            this.gbxMonitor.Text = "Monitor/Kill";
            // 
            // dgvProcesses
            // 
            this.dgvProcesses.AllowUserToAddRows = false;
            this.dgvProcesses.AllowUserToDeleteRows = false;
            this.dgvProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFileName,
            this.ColProcessID,
            this.ColCPUTime,
            this.ColProcess});
            this.dgvProcesses.Location = new System.Drawing.Point(7, 20);
            this.dgvProcesses.MultiSelect = false;
            this.dgvProcesses.Name = "dgvProcesses";
            this.dgvProcesses.ReadOnly = true;
            this.dgvProcesses.RowHeadersVisible = false;
            this.dgvProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcesses.Size = new System.Drawing.Size(447, 185);
            this.dgvProcesses.TabIndex = 2;
            // 
            // ColFileName
            // 
            this.ColFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFileName.HeaderText = "Process Name";
            this.ColFileName.Name = "ColFileName";
            this.ColFileName.ReadOnly = true;
            // 
            // ColProcessID
            // 
            this.ColProcessID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColProcessID.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColProcessID.HeaderText = "Process ID";
            this.ColProcessID.Name = "ColProcessID";
            this.ColProcessID.ReadOnly = true;
            this.ColProcessID.Width = 84;
            // 
            // ColCPUTime
            // 
            this.ColCPUTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColCPUTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColCPUTime.HeaderText = "CPU Time";
            this.ColCPUTime.Name = "ColCPUTime";
            this.ColCPUTime.ReadOnly = true;
            this.ColCPUTime.Width = 80;
            // 
            // ColProcess
            // 
            this.ColProcess.HeaderText = "Process";
            this.ColProcess.Name = "ColProcess";
            this.ColProcess.ReadOnly = true;
            this.ColProcess.Visible = false;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(192, 211);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(75, 23);
            this.btnTerminate.TabIndex = 1;
            this.btnTerminate.Text = "Terminate";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // ofdProgram
            // 
            this.ofdProgram.Filter = "Executable Files|*.exe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.gbxMonitor);
            this.Controls.Add(this.gbxStart);
            this.Name = "Form1";
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxStart.ResumeLayout(false);
            this.gbxStart.PerformLayout();
            this.gbxMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.GroupBox gbxMonitor;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.DataGridView dgvProcesses;
        private System.Windows.Forms.OpenFileDialog ofdProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCPUTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProcess;
    }
}

