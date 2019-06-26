namespace SPPO_labs.UCs
{
    partial class UCLab1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbCoord = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.gpbText = new System.Windows.Forms.GroupBox();
            this.txb = new System.Windows.Forms.TextBox();
            this.gpbData = new System.Windows.Forms.GroupBox();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.spc = new System.Windows.Forms.SplitContainer();
            this.gpbCoord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.gpbText.SuspendLayout();
            this.gpbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc)).BeginInit();
            this.spc.Panel1.SuspendLayout();
            this.spc.Panel2.SuspendLayout();
            this.spc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCoord
            // 
            this.gpbCoord.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCoord.Controls.Add(this.dgvResult);
            this.gpbCoord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbCoord.Location = new System.Drawing.Point(0, 0);
            this.gpbCoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCoord.Name = "gpbCoord";
            this.gpbCoord.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCoord.Size = new System.Drawing.Size(222, 47);
            this.gpbCoord.TabIndex = 2;
            this.gpbCoord.TabStop = false;
            this.gpbCoord.Text = "Системное время и координаты";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.ColumnHeadersVisible = false;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(2, 15);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 28;
            this.dgvResult.Size = new System.Drawing.Size(218, 30);
            this.dgvResult.TabIndex = 1;
            // 
            // gpbText
            // 
            this.gpbText.Controls.Add(this.txb);
            this.gpbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbText.Location = new System.Drawing.Point(0, 0);
            this.gpbText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbText.Name = "gpbText";
            this.gpbText.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbText.Size = new System.Drawing.Size(222, 65);
            this.gpbText.TabIndex = 0;
            this.gpbText.TabStop = false;
            this.gpbText.Text = "Навигационые данные";
            // 
            // txb
            // 
            this.txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb.Location = new System.Drawing.Point(2, 15);
            this.txb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb.Multiline = true;
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(218, 48);
            this.txb.TabIndex = 1;
            this.txb.TextChanged += new System.EventHandler(this.txb_TextChanged);
            // 
            // gpbData
            // 
            this.gpbData.Controls.Add(this.dgvParams);
            this.gpbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbData.Location = new System.Drawing.Point(0, 0);
            this.gpbData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbData.Name = "gpbData";
            this.gpbData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbData.Size = new System.Drawing.Size(222, 161);
            this.gpbData.TabIndex = 1;
            this.gpbData.TabStop = false;
            this.gpbData.Text = "Извлечённые параметры";
            // 
            // dgvParams
            // 
            this.dgvParams.AllowUserToAddRows = false;
            this.dgvParams.AllowUserToDeleteRows = false;
            this.dgvParams.AllowUserToResizeColumns = false;
            this.dgvParams.AllowUserToResizeRows = false;
            this.dgvParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvParams.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.ColumnHeadersVisible = false;
            this.dgvParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParams.Location = new System.Drawing.Point(2, 15);
            this.dgvParams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.ReadOnly = true;
            this.dgvParams.RowHeadersVisible = false;
            this.dgvParams.RowTemplate.Height = 28;
            this.dgvParams.Size = new System.Drawing.Size(218, 144);
            this.dgvParams.TabIndex = 0;
            // 
            // spc
            // 
            this.spc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc.Location = new System.Drawing.Point(0, 65);
            this.spc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spc.Name = "spc";
            this.spc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc.Panel1
            // 
            this.spc.Panel1.Controls.Add(this.gpbData);
            // 
            // spc.Panel2
            // 
            this.spc.Panel2.Controls.Add(this.gpbCoord);
            this.spc.Size = new System.Drawing.Size(222, 211);
            this.spc.SplitterDistance = 161;
            this.spc.SplitterWidth = 3;
            this.spc.TabIndex = 3;
            this.spc.TabStop = false;
            // 
            // UCLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spc);
            this.Controls.Add(this.gpbText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCLab1";
            this.Size = new System.Drawing.Size(222, 276);
            this.gpbCoord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.gpbText.ResumeLayout(false);
            this.gpbText.PerformLayout();
            this.gpbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.spc.Panel1.ResumeLayout(false);
            this.spc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc)).EndInit();
            this.spc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCoord;
        private System.Windows.Forms.GroupBox gpbText;
        private System.Windows.Forms.GroupBox gpbData;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.SplitContainer spc;
    }
}
