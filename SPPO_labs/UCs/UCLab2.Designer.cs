namespace SPPO_labs.UCs
{
    partial class UCLab2
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
            this.gpbParams = new System.Windows.Forms.GroupBox();
            this.gpbVectorComponents = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.gpbParams.SuspendLayout();
            this.gpbVectorComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbParams
            // 
            this.gpbParams.Controls.Add(this.dgvParams);
            this.gpbParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbParams.Location = new System.Drawing.Point(0, 0);
            this.gpbParams.Name = "gpbParams";
            this.gpbParams.Size = new System.Drawing.Size(150, 120);
            this.gpbParams.TabIndex = 0;
            this.gpbParams.TabStop = false;
            this.gpbParams.Text = "Используемые параметры для расчета скорости для расчёта компонентов вектора скоро" +
    "сти спутника";
            // 
            // gpbVectorComponents
            // 
            this.gpbVectorComponents.Controls.Add(this.dgvResult);
            this.gpbVectorComponents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbVectorComponents.Location = new System.Drawing.Point(0, 120);
            this.gpbVectorComponents.Name = "gpbVectorComponents";
            this.gpbVectorComponents.Size = new System.Drawing.Size(150, 111);
            this.gpbVectorComponents.TabIndex = 1;
            this.gpbVectorComponents.TabStop = false;
            this.gpbVectorComponents.Text = "Компоненты вектора относительной скорости навигационного спутника в гринвичской с" +
    "истем координат";
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
            this.dgvResult.Location = new System.Drawing.Point(3, 16);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 28;
            this.dgvResult.Size = new System.Drawing.Size(144, 92);
            this.dgvResult.TabIndex = 2;
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
            this.dgvParams.Location = new System.Drawing.Point(3, 16);
            this.dgvParams.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.ReadOnly = true;
            this.dgvParams.RowHeadersVisible = false;
            this.dgvParams.RowTemplate.Height = 28;
            this.dgvParams.Size = new System.Drawing.Size(144, 101);
            this.dgvParams.TabIndex = 1;
            // 
            // UCLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbParams);
            this.Controls.Add(this.gpbVectorComponents);
            this.Name = "UCLab2";
            this.Size = new System.Drawing.Size(150, 231);
            this.gpbParams.ResumeLayout(false);
            this.gpbVectorComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbParams;
        private System.Windows.Forms.GroupBox gpbVectorComponents;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridView dgvParams;
    }
}
