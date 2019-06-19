using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPPO_labs.Classes;

namespace SPPO_labs.UCs
{
    public partial class UCLab1 : UserControl
    {
        private Lab1 _lab1;

        public UCLab1()
        {
            Dock = DockStyle.Fill;

            InitializeComponent();

            _lab1 = new Lab1();
        }

        private void OutputToClipboard(DataGridView dgv)
        {
            int width = 1;
            foreach (DataGridViewColumn column in dgv.Columns)
                width += column.Width;
            int height = 1;
            foreach (DataGridViewRow row in dgv.Rows)
                height += row.Height;
            dgv.Dock = DockStyle.None;
            dgv.Width = width + 10;
            dgv.Height = height + 10;
            Bitmap bmp = new Bitmap(width, height);
            dgv.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            Clipboard.SetImage(bmp);
            dgv.Dock = DockStyle.Fill;
        }

        private void txb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _lab1.Parse(txb.Text);
                _lab1.ShowData(dgvParams);
                _lab1.CalculateCoordAndSystemTime(dgvResult);
            }
            catch (Exception ex)
            { var q = ex.Message; }
        }

        private void извлечённыеПараметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputToClipboard(dgvParams);
        }

        private void системноеВремяИКоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputToClipboard(dgvResult);
        }
    }
}
