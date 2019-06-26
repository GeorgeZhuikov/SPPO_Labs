using System.Drawing;
using System.Windows.Forms;

namespace SPPO_labs.Classes
{
    public static class Helper
    {
        public static void OutputToClipboard(DataGridView dgv)
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

        public static void AddRowToDgv(DataGridView dgv, string text, string sign, object value)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = dgv.RowCount + 1 });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = text });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = sign });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = value });
            dgv.Rows.Add(row);
        }
    }
}
