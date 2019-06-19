namespace SPPO_labs
{
    partial class Form
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
            this.ucLab11 = new SPPO_labs.UCs.UCLab1();
            this.SuspendLayout();
            // 
            // ucLab11
            // 
            this.ucLab11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLab11.Location = new System.Drawing.Point(0, 0);
            this.ucLab11.Name = "ucLab11";
            this.ucLab11.Size = new System.Drawing.Size(278, 244);
            this.ucLab11.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.ucLab11);
            this.Name = "Form";
            this.Text = "СППО Лабораторные";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UCs.UCLab1 ucLab11;
    }
}

