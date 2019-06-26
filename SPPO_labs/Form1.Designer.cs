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
            this.mns = new System.Windows.Forms.MenuStrip();
            this.выводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извлечённыеПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системноеВремяИКоординатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbp1 = new System.Windows.Forms.TabPage();
            this.ucLab1 = new SPPO_labs.UCs.UCLab1();
            this.tbp2 = new System.Windows.Forms.TabPage();
            this.ucLab2 = new SPPO_labs.UCs.UCLab2();
            this.используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mns.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbp1.SuspendLayout();
            this.tbp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns
            // 
            this.mns.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводToolStripMenuItem});
            this.mns.Location = new System.Drawing.Point(0, 0);
            this.mns.Name = "mns";
            this.mns.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mns.Size = new System.Drawing.Size(185, 24);
            this.mns.TabIndex = 5;
            this.mns.Text = "menuStrip1";
            // 
            // выводToolStripMenuItem
            // 
            this.выводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.извлечённыеПараметрыToolStripMenuItem,
            this.системноеВремяИКоординатыToolStripMenuItem,
            this.используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem,
            this.компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem});
            this.выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            this.выводToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.выводToolStripMenuItem.Text = "Вывод в буфер обмена";
            // 
            // извлечённыеПараметрыToolStripMenuItem
            // 
            this.извлечённыеПараметрыToolStripMenuItem.Name = "извлечённыеПараметрыToolStripMenuItem";
            this.извлечённыеПараметрыToolStripMenuItem.Size = new System.Drawing.Size(642, 22);
            this.извлечённыеПараметрыToolStripMenuItem.Text = "Извлечённые параметры";
            this.извлечённыеПараметрыToolStripMenuItem.Click += new System.EventHandler(this.ИзвлечённыеПараметрыToolStripMenuItem_Click);
            // 
            // системноеВремяИКоординатыToolStripMenuItem
            // 
            this.системноеВремяИКоординатыToolStripMenuItem.Name = "системноеВремяИКоординатыToolStripMenuItem";
            this.системноеВремяИКоординатыToolStripMenuItem.Size = new System.Drawing.Size(642, 22);
            this.системноеВремяИКоординатыToolStripMenuItem.Text = "Системное время и координаты";
            this.системноеВремяИКоординатыToolStripMenuItem.Click += new System.EventHandler(this.СистемноеВремяИКоординатыToolStripMenuItem_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbp1);
            this.tbc.Controls.Add(this.tbp2);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(0, 24);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(185, 135);
            this.tbc.TabIndex = 6;
            // 
            // tbp1
            // 
            this.tbp1.BackColor = System.Drawing.SystemColors.Control;
            this.tbp1.Controls.Add(this.ucLab1);
            this.tbp1.Location = new System.Drawing.Point(4, 22);
            this.tbp1.Name = "tbp1";
            this.tbp1.Padding = new System.Windows.Forms.Padding(3);
            this.tbp1.Size = new System.Drawing.Size(177, 109);
            this.tbp1.TabIndex = 0;
            this.tbp1.Text = "Лабораторная 1";
            // 
            // ucLab1
            // 
            this.ucLab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLab1.Location = new System.Drawing.Point(3, 3);
            this.ucLab1.Margin = new System.Windows.Forms.Padding(2);
            this.ucLab1.Name = "ucLab1";
            this.ucLab1.Size = new System.Drawing.Size(171, 103);
            this.ucLab1.TabIndex = 0;
            // 
            // tbp2
            // 
            this.tbp2.BackColor = System.Drawing.SystemColors.Control;
            this.tbp2.Controls.Add(this.ucLab2);
            this.tbp2.Location = new System.Drawing.Point(4, 22);
            this.tbp2.Name = "tbp2";
            this.tbp2.Padding = new System.Windows.Forms.Padding(3);
            this.tbp2.Size = new System.Drawing.Size(177, 109);
            this.tbp2.TabIndex = 1;
            this.tbp2.Text = "Лабораторная 2";
            // 
            // ucLab2
            // 
            this.ucLab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLab2.Location = new System.Drawing.Point(3, 3);
            this.ucLab2.Name = "ucLab2";
            this.ucLab2.Size = new System.Drawing.Size(171, 103);
            this.ucLab2.TabIndex = 0;
            // 
            // используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem
            // 
            this.используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem.Name = "используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутни" +
    "каToolStripMenuItem";
            this.используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem.Size = new System.Drawing.Size(666, 22);
            this.используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem.Text = "Используемые параметры для расчета скорости для расчёта компонентов вектора скоро" +
    "сти спутника";
            this.используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem.Click += new System.EventHandler(this.ИспользуемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem_Click);
            // 
            // компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem
            // 
            this.компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem.Name = "компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоо" +
    "рдинатToolStripMenuItem";
            this.компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem.Size = new System.Drawing.Size(666, 22);
            this.компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem.Text = "Компоненты вектора относительной скорости навигационного спутника в гринвичской с" +
    "истем координат";
            this.компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem.Click += new System.EventHandler(this.КомпонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 159);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.mns);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "СППО Лабораторные";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mns.ResumeLayout(false);
            this.mns.PerformLayout();
            this.tbc.ResumeLayout(false);
            this.tbp1.ResumeLayout(false);
            this.tbp2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns;
        private System.Windows.Forms.ToolStripMenuItem выводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извлечённыеПараметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системноеВремяИКоординатыToolStripMenuItem;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbp1;
        private System.Windows.Forms.TabPage tbp2;
        private UCs.UCLab1 ucLab1;
        private UCs.UCLab2 ucLab2;
        private System.Windows.Forms.ToolStripMenuItem используемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem;
    }
}

