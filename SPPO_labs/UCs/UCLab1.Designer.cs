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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извлечённыеПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системноеВремяИКоординатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbCoord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.gpbText.SuspendLayout();
            this.gpbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc)).BeginInit();
            this.spc.Panel1.SuspendLayout();
            this.spc.Panel2.SuspendLayout();
            this.spc.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCoord
            // 
            this.gpbCoord.BackColor = System.Drawing.SystemColors.Control;
            this.gpbCoord.Controls.Add(this.dgvResult);
            this.gpbCoord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbCoord.Location = new System.Drawing.Point(0, 0);
            this.gpbCoord.Name = "gpbCoord";
            this.gpbCoord.Size = new System.Drawing.Size(333, 64);
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
            this.dgvResult.Location = new System.Drawing.Point(3, 22);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 28;
            this.dgvResult.Size = new System.Drawing.Size(327, 39);
            this.dgvResult.TabIndex = 1;
            // 
            // gpbText
            // 
            this.gpbText.Controls.Add(this.txb);
            this.gpbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbText.Location = new System.Drawing.Point(0, 33);
            this.gpbText.Name = "gpbText";
            this.gpbText.Size = new System.Drawing.Size(333, 100);
            this.gpbText.TabIndex = 0;
            this.gpbText.TabStop = false;
            this.gpbText.Text = "Навигационые данные";
            // 
            // txb
            // 
            this.txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb.Location = new System.Drawing.Point(3, 22);
            this.txb.Multiline = true;
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(327, 75);
            this.txb.TabIndex = 1;
            this.txb.TextChanged += new System.EventHandler(this.txb_TextChanged);
            // 
            // gpbData
            // 
            this.gpbData.Controls.Add(this.dgvParams);
            this.gpbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbData.Location = new System.Drawing.Point(0, 0);
            this.gpbData.Name = "gpbData";
            this.gpbData.Size = new System.Drawing.Size(333, 224);
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
            this.dgvParams.Location = new System.Drawing.Point(3, 22);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.ReadOnly = true;
            this.dgvParams.RowHeadersVisible = false;
            this.dgvParams.RowTemplate.Height = 28;
            this.dgvParams.Size = new System.Drawing.Size(327, 199);
            this.dgvParams.TabIndex = 0;
            // 
            // spc
            // 
            this.spc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc.Location = new System.Drawing.Point(0, 133);
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
            this.spc.Size = new System.Drawing.Size(333, 292);
            this.spc.SplitterDistance = 224;
            this.spc.TabIndex = 3;
            this.spc.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выводToolStripMenuItem
            // 
            this.выводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.извлечённыеПараметрыToolStripMenuItem,
            this.системноеВремяИКоординатыToolStripMenuItem});
            this.выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            this.выводToolStripMenuItem.Size = new System.Drawing.Size(216, 29);
            this.выводToolStripMenuItem.Text = "Вывод в буфер обмена";
            // 
            // извлечённыеПараметрыToolStripMenuItem
            // 
            this.извлечённыеПараметрыToolStripMenuItem.Name = "извлечённыеПараметрыToolStripMenuItem";
            this.извлечённыеПараметрыToolStripMenuItem.Size = new System.Drawing.Size(362, 30);
            this.извлечённыеПараметрыToolStripMenuItem.Text = "Извлечённые параметры";
            this.извлечённыеПараметрыToolStripMenuItem.Click += new System.EventHandler(this.извлечённыеПараметрыToolStripMenuItem_Click);
            // 
            // системноеВремяИКоординатыToolStripMenuItem
            // 
            this.системноеВремяИКоординатыToolStripMenuItem.Name = "системноеВремяИКоординатыToolStripMenuItem";
            this.системноеВремяИКоординатыToolStripMenuItem.Size = new System.Drawing.Size(362, 30);
            this.системноеВремяИКоординатыToolStripMenuItem.Text = "Системное время и координаты";
            this.системноеВремяИКоординатыToolStripMenuItem.Click += new System.EventHandler(this.системноеВремяИКоординатыToolStripMenuItem_Click);
            // 
            // UCLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spc);
            this.Controls.Add(this.gpbText);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCLab1";
            this.Size = new System.Drawing.Size(333, 425);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCoord;
        private System.Windows.Forms.GroupBox gpbText;
        private System.Windows.Forms.GroupBox gpbData;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.SplitContainer spc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извлечённыеПараметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системноеВремяИКоординатыToolStripMenuItem;
    }
}
