using System;
using System.Windows.Forms;
using SPPO_labs.Classes;

namespace SPPO_labs.UCs
{
    public partial class UCLab1 : UserControl
    {
        private Lab1 _lab1;

        public DataGridView DgvParams { get { return dgvParams; } }
        public DataGridView DgvResult { get { return dgvResult; } }
        public UCLab2 UCLab2 { get; set; }

        public UCLab1()
        {
            Dock = DockStyle.Fill;
            _lab1 = new Lab1();

            InitializeComponent();
        }

        private void txb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _lab1.Parse(txb.Text);
                _lab1.ShowData(dgvParams);
                _lab1.CalculateCoordAndSystemTime(dgvResult);
                UCLab2.SatelliteData = _lab1.SatelliteData;
                UCLab2.CalculateLab1Data = _lab1.CalculateLab1Data;
                UCLab2.CalculateLab2();
            }
            catch (Exception ex)
            { var q = ex.Message; }
        }
    }
}
