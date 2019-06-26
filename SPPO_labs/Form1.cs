using SPPO_labs.Classes;
using System;

namespace SPPO_labs
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            ucLab1.UCLab2 = ucLab2;
        }

        private void ИзвлечённыеПараметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.OutputToClipboard(ucLab1.DgvParams);
        }

        private void СистемноеВремяИКоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.OutputToClipboard(ucLab1.DgvResult);
        }

        private void ИспользуемыеПараметрыДляРасчетаСкоростиДляРасчётаКомпонентовВектораСкоростиСпутникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.OutputToClipboard(ucLab2.DgvParams);
        }

        private void КомпонентыВектораОтносительнойСкоростиНавигационногоСпутникаВГринвичскойСистемКоординатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.OutputToClipboard(ucLab2.DgvResult);
        }
    }
}
