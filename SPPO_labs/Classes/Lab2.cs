using SPPO_labs.Data;
using System;
using System.Windows.Forms;

namespace SPPO_labs.Classes
{
    public class Lab2
    {
        /// <summary>
        /// Извлеченные параметры из навигационных данных
        /// </summary>
        public SatelliteData SatelliteData { get; set; }
        /// <summary>
        /// Расчётные параметры
        /// </summary>
        public CalculateLab1Data CalculateLab1Data { get; set; }
        /// <summary>
        /// Расчётные параметры
        /// </summary>
        public CalculateLab2Data CalculateLab2Data { get; private set; }

        #region Private part

        private void CalculateDerivatives()
        {
            CalculateLab2Data._v = (Math.Sqrt(CalculateLab1Data.Mu) / Math.Pow(CalculateLab1Data.A, 3.0 / 2) + SatelliteData.delta_n) * Math.Sqrt(1 - Math.Pow(SatelliteData.e, 2))
                / Math.Pow(1 - SatelliteData.e * CalculateLab1Data.Ek, 2);
            CalculateLab2Data._delta_u = 2 * (SatelliteData.Cus * Math.Cos(2 * CalculateLab1Data.U_) - SatelliteData.Cus * Math.Sin(2 * CalculateLab1Data.U_)) * CalculateLab2Data._v;
            CalculateLab2Data._delta_r = 2 * (SatelliteData.Crs * Math.Cos(2 * CalculateLab1Data.U_) - SatelliteData.Crs * Math.Sin(2 * CalculateLab1Data.U_)) * CalculateLab2Data._v;
            CalculateLab2Data._delta_i = 2 * (SatelliteData.Cis * Math.Cos(2 * CalculateLab1Data.U_) - SatelliteData.Cis * Math.Sin(2 * CalculateLab1Data.U_)) * CalculateLab2Data._v;
        }

        private void CalculateModulsSpeedComponents()
        {
            CalculateLab2Data.v_r = CalculateLab1Data.A * (Math.Sqrt(CalculateLab1Data.Mu) / Math.Pow(CalculateLab1Data.A, 3.0 / 2) + SatelliteData.delta_n)
                * SatelliteData.e * Math.Sin(CalculateLab1Data.Ek) / (1 - SatelliteData.e * Math.Cos(CalculateLab1Data.Ek)) + CalculateLab2Data._delta_r;
            CalculateLab2Data.v_u = CalculateLab1Data.r * (CalculateLab2Data._v + CalculateLab2Data._delta_u);
        }

        private void CalculateVectorComponents()
        {
            var cosU = Math.Cos(CalculateLab1Data.U);
            var sinU = Math.Sin(CalculateLab1Data.U);
            CalculateLab2Data.v_1_ = CalculateLab2Data.v_r * cosU - CalculateLab2Data.v_u * sinU;
            CalculateLab2Data.v_2_ = CalculateLab2Data.v_r * sinU - CalculateLab2Data.v_u * cosU;
            CalculateLab2Data.v_3_ = CalculateLab1Data.r * Math.Sin(CalculateLab2Data._v) * (SatelliteData.IDOT + CalculateLab2Data._delta_i);
        }

        private void CalculateVectorAbsoluteComponents()
        {
            var cosL = Math.Cos(CalculateLab1Data.lambda);
            var sinL = Math.Sin(CalculateLab1Data.lambda);
            var cosi = Math.Cos(CalculateLab1Data.i);
            var sini = Math.Sin(CalculateLab1Data.i);
            CalculateLab2Data.v_1 = CalculateLab2Data.v_1_ * cosL - CalculateLab2Data.v_2_ * cosi * sinL + CalculateLab2Data.v_3_ * sini * cosL;
            CalculateLab2Data.v_2 = CalculateLab2Data.v_1_ * sinL + CalculateLab2Data.v_2_ * cosi * cosL - CalculateLab2Data.v_3_ * sini * cosL;
            CalculateLab2Data.v_3 = CalculateLab2Data.v_2_ * sini + CalculateLab2Data.v_3_ * cosi;
        }

        private void CalculateVectorComponentsXYZ()
        {
            CalculateLab2Data.v_x = CalculateLab2Data.v_1 + (CalculateLab1Data.Omega_e - SatelliteData.Omega_) * CalculateLab1Data.Y;
            CalculateLab2Data.v_y = CalculateLab2Data.v_2 - (CalculateLab1Data.Omega_e - SatelliteData.Omega_) * CalculateLab1Data.X;
            CalculateLab2Data.v_z = CalculateLab2Data.v_3;
        }

        #endregion

        #region Public part
        public void Calculate()
        {
            CalculateLab2Data = new CalculateLab2Data();
            CalculateDerivatives();
            CalculateModulsSpeedComponents();
            CalculateVectorComponents();
            CalculateVectorAbsoluteComponents();
            CalculateVectorComponentsXYZ();
        }

        public void ShowParams(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Rows.Clear();
            Helper.AddRowToDgv(dgv, "Производная истинной аномалии", "v'", CalculateLab2Data._v);
            Helper.AddRowToDgv(dgv, "Производная параметров коррекции аргумента широты", "δu'", CalculateLab2Data._delta_u);
            Helper.AddRowToDgv(dgv, "Производная параметров коррекции аргумента радиуса", "δr'", CalculateLab2Data._delta_r);
            Helper.AddRowToDgv(dgv, "Производная параметров коррекции аргумента угла наклона орбиты", "δi'", CalculateLab2Data._delta_i);
            Helper.AddRowToDgv(dgv, "Модуль радиальной составляющей скорости спутника", "v_r", CalculateLab2Data.v_r);
            Helper.AddRowToDgv(dgv, "Модуль трансверсальной составляющей скорости спутника", "v_u", CalculateLab2Data.v_u);
            Helper.AddRowToDgv(dgv, "Компонент вектора угловой скорости движения спутника в орбитальной системе координат", "v_1'", CalculateLab2Data.v_1_);
            Helper.AddRowToDgv(dgv, "Компонент вектора угловой скорости движения спутника в орбитальной системе координат", "v_2'", CalculateLab2Data.v_2_);
            Helper.AddRowToDgv(dgv, "Компонент вектора угловой скорости движения спутника в орбитальной системе координат", "v_3'", CalculateLab2Data.v_3_);
            Helper.AddRowToDgv(dgv, "Компонент вектора абсолютной скорости движения спутника в орбитальной системе координат", "v_1", CalculateLab2Data.v_1);
            Helper.AddRowToDgv(dgv, "Компонент вектора абсолютной скорости движения спутника в орбитальной системе координат", "v_2", CalculateLab2Data.v_2);
            Helper.AddRowToDgv(dgv, "Компонент вектора абсолютной скорости движения спутника в орбитальной системе координат", "v_3", CalculateLab2Data.v_3);
            dgv.ClearSelection();
        }

        public void ShowSpeedVectors(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Rows.Clear();
            Helper.AddRowToDgv(dgv, "Компонент вектора относительной скорости навигационного спутника в гринвичской систем координат", "Х", CalculateLab2Data.v_x);
            Helper.AddRowToDgv(dgv, "Компонент вектора относительной скорости навигационного спутника в гринвичской систем координат", "Y", CalculateLab2Data.v_y);
            Helper.AddRowToDgv(dgv, "Компонент вектора относительной скорости навигационного спутника в гринвичской систем координат", "Z", CalculateLab2Data.v_z);
            dgv.ClearSelection();
        }

        #endregion
    }
}
