using System;
using System.Windows.Forms;
using SPPO_labs.Classes;
using SPPO_labs.Data;

namespace SPPO_labs.UCs
{
    public partial class UCLab2 : UserControl
    {
        private Lab2 _lab2;

        public DataGridView DgvParams { get { return dgvParams; } }
        public DataGridView DgvResult { get { return dgvResult; } }
        public SatelliteData SatelliteData { set { _lab2.SatelliteData = value; } }
        public CalculateLab1Data CalculateLab1Data { set { _lab2.CalculateLab1Data = value; } }

        public UCLab2()
        {
            Dock = DockStyle.Fill;
            _lab2 = new Lab2();

            InitializeComponent();
        }

        public void CalculateLab2()
        {
            _lab2.Calculate();
            _lab2.ShowParams(dgvParams);
            _lab2.ShowSpeedVectors(dgvResult);
        }
    }
}
