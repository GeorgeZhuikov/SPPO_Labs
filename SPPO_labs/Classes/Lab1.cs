using SPPO_labs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPO_labs.Classes
{
    public class Lab1
    {
        /// <summary>
        /// Извлеченные параметры из навигационных данных
        /// </summary>
        public SatelliteData SatelliteData { get; private set; }
        /// <summary>
        /// Расчётные параметры
        /// </summary>
        public CalculateLab1Data CalculateLab1Data { get; private set; }

        private string[] GetData(string text)
        {
            var data = text.Replace("-", " -")
                .Replace("D ", "D")
                .Replace("D", "E")
                .Replace("\n", "")
                .Replace("\r", "")
                .Split(' ');
            List<string> newData = new List<string>();
            foreach (var note in data)
                if (note != "")
                    newData.Add(note.Trim().Replace(".",","));
            return newData.ToArray();
        }        

        private void PreCalculation()
        {
            CalculateLab1Data.delta_tr = 0;
            CalculateLab1Data.A = Math.Pow(SatelliteData.sqrt_A, 2);
            CalculateLab1Data.n0 = Math.Sqrt(CalculateLab1Data.Mu / Math.Pow(CalculateLab1Data.A, 3));
            CalculateLab1Data.n = CalculateLab1Data.n0 + SatelliteData.delta_n;
            CalculateLab1Data.Mk = SatelliteData.M0 + CalculateLab1Data.n * CalculateLab1Data.tk;
        }

        private void CalculateTime()
        {
            CalculateLab1Data.t = SatelliteData.toe + CalculateLab1Data.UpdateTimeSec;
            CalculateLab1Data.delta_t = SatelliteData.af0 + SatelliteData.af1 * CalculateLab1Data.UpdateTimeSec
                + SatelliteData.af2 * Math.Pow(CalculateLab1Data.UpdateTimeSec, 2) + CalculateLab1Data.delta_tr;
            CalculateLab1Data.tk = CalculateLab1Data.t - CalculateLab1Data.delta_t - SatelliteData.toe;
        }

        private double EkIteration()
        {
            double latestEk = CalculateLab1Data.Ek;
            CalculateTime();
            CalculateLab1Data.Ek = CalculateLab1Data.Mk + (SatelliteData.e - Math.Pow(SatelliteData.e, 3.0 / 8)) * Math.Sin(CalculateLab1Data.Mk)
                + Math.Pow(SatelliteData.e, 2) * Math.Sin(2 * CalculateLab1Data.Mk) / 2
                + 3 * Math.Pow(SatelliteData.e, 3.0 / 8) * Math.Sin(3 * CalculateLab1Data.Mk);
            CalculateLab1Data.Ek += (SatelliteData.e * Math.Sin(CalculateLab1Data.Ek) + CalculateLab1Data.Mk - CalculateLab1Data.Ek)
                / (1 - SatelliteData.e * Math.Sin(CalculateLab1Data.Ek));
            CalculateLab1Data.delta_tr = -2 * Math.Sqrt(CalculateLab1Data.Mu) * SatelliteData.e * SatelliteData.sqrt_A
                * Math.Sin(CalculateLab1Data.Ek) / Math.Pow(CalculateLab1Data.c, 2);
            return latestEk;
        }

        private void CalculateFinalCoord()
        {
            CalculateLab1Data.CosYpsilon = (Math.Cos(CalculateLab1Data.Ek) - SatelliteData.e) 
                / (1 - SatelliteData.e * Math.Cos(CalculateLab1Data.Ek));
            CalculateLab1Data.Ypsilon = Math.Acos(CalculateLab1Data.CosYpsilon) + 1.5 * Math.PI;
            CalculateLab1Data.U_ = CalculateLab1Data.Ypsilon + SatelliteData.omega;
            CalculateLab1Data.U = CalculateLab1Data.U_ + SatelliteData.Cus * Math.Sin(2 * CalculateLab1Data.U_) + SatelliteData.Cuc * Math.Cos(2 * CalculateLab1Data.U_);
            CalculateLab1Data.r = CalculateLab1Data.A * (1 - SatelliteData.e * Math.Cos(CalculateLab1Data.Ek))
                + SatelliteData.Crs * Math.Sin(2 * CalculateLab1Data.U)
                + SatelliteData.Crc * Math.Cos(2 * CalculateLab1Data.U);
            CalculateLab1Data.i = SatelliteData.i0 + SatelliteData.Cis * Math.Sin(2 * CalculateLab1Data.U)
                + SatelliteData.Cic * Math.Cos(2 * CalculateLab1Data.U)
                + SatelliteData.IDOT * CalculateLab1Data.tk;
            double x_ = CalculateLab1Data.r * Math.Cos(CalculateLab1Data.U);
            double y_ = CalculateLab1Data.r * Math.Sin(CalculateLab1Data.U);
            CalculateLab1Data.lambda = SatelliteData.Omega_0 + (SatelliteData.Omega_ - CalculateLab1Data.Omega_e) * CalculateLab1Data.tk
                - CalculateLab1Data.Omega_e * SatelliteData.toe;
            CalculateLab1Data.X = x_ * Math.Cos(CalculateLab1Data.lambda) 
                - y_ * Math.Cos(CalculateLab1Data.i) * Math.Sin(CalculateLab1Data.lambda);
            CalculateLab1Data.Y = x_ * Math.Sin(CalculateLab1Data.lambda)
                + y_ * Math.Cos(CalculateLab1Data.i) * Math.Cos(CalculateLab1Data.lambda);
            CalculateLab1Data.Z = y_ * Math.Cos(CalculateLab1Data.i);
        }

        private void ShowResult(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Rows.Clear();
            Helper.AddRowToDgv(dgv, "Время излучения метки времени по системной шкале", 
                "tk", CalculateLab1Data.tk);
            Helper.AddRowToDgv(dgv, "Поправка для перехода от бортовой шкалы времени к системной"
                + " шкале", "Δt", CalculateLab1Data.delta_t);
            Helper.AddRowToDgv(dgv, "Поправка на релятивистский эффект", "Δtr", CalculateLab1Data.delta_tr);
            Helper.AddRowToDgv(dgv, "Координта спутника Х", "Х", CalculateLab1Data.X);
            Helper.AddRowToDgv(dgv, "Координта спутника Y", "Y", CalculateLab1Data.Y);
            Helper.AddRowToDgv(dgv, "Координта спутника Z", "Z", CalculateLab1Data.Z);
            dgv.ClearSelection();
        }

        internal void CalculateCoordAndSystemTime(DataGridView dgv)
        {
            PreCalculation();
            EkIteration();
            for (;Math.Abs(CalculateLab1Data.Ek - EkIteration()) > CalculateLab1Data.Accuracy;) { }
            CalculateFinalCoord();
            ShowResult(dgv);
        }

        internal void Parse(string text)
        {
            SatelliteData = new SatelliteData();
            CalculateLab1Data = new CalculateLab1Data();
            var data = GetData(text);
            int index = 0;
            SatelliteData.PRN = Convert.ToInt32(data[index++]);
            SatelliteData.Date = new DateTime(
                Convert.ToInt32(data[index++]) + 2000,
                Convert.ToInt32(data[index++]),
                Convert.ToInt32(data[index++]), 
                Convert.ToInt32(data[index++]),
                Convert.ToInt32(data[index++]), 
                (int)Convert.ToDouble(data[index++]));
            SatelliteData.af0 = Convert.ToDouble(data[index++]);
            SatelliteData.af1 = Convert.ToDouble(data[index++]);
            SatelliteData.af2 = Convert.ToDouble(data[index++]);
            SatelliteData.AOED = Convert.ToDouble(data[index++]);
            SatelliteData.Crs = Convert.ToDouble(data[index++]);
            SatelliteData.delta_n = Convert.ToDouble(data[index++]);
            SatelliteData.M0 = Convert.ToDouble(data[index++]);
            SatelliteData.Cuc = Convert.ToDouble(data[index++]);
            SatelliteData.e = Convert.ToDouble(data[index++]);
            SatelliteData.Cus = Convert.ToDouble(data[index++]);
            SatelliteData.sqrt_A = Convert.ToDouble(data[index++]);
            SatelliteData.toe = Convert.ToDouble(data[index++]);
            SatelliteData.Cic = Convert.ToDouble(data[index++]);
            SatelliteData.Omega_0 = Convert.ToDouble(data[index++]);
            SatelliteData.Cis = Convert.ToDouble(data[index++]);
            SatelliteData.i0 = Convert.ToDouble(data[index++]);
            SatelliteData.Crc = Convert.ToDouble(data[index++]);
            SatelliteData.omega = Convert.ToDouble(data[index++]);
            SatelliteData.Omega_ = Convert.ToDouble(data[index++]);
            SatelliteData.IDOT = Convert.ToDouble(data[index++]);
            index = 32;
            SatelliteData.delta_tg = Convert.ToDouble(data[index++]);
            SatelliteData.AODC = Convert.ToDouble(data[index++]);
        }

        internal void ShowData(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Rows.Clear();
            Helper.AddRowToDgv(dgv, "Номер спутника", "PRN", SatelliteData.PRN);
            Helper.AddRowToDgv(dgv, "Дата и время", "Date", SatelliteData.Date);
            Helper.AddRowToDgv(dgv, "Смещение времени (сек)", "af0", SatelliteData.af0);
            Helper.AddRowToDgv(dgv, "Отношение (сек/сек)", "af1", SatelliteData.af1);
            Helper.AddRowToDgv(dgv, "Ускорение (сек/сек2)", "af2", SatelliteData.af2);
            Helper.AddRowToDgv(dgv, "Возраст эфемерид (сек)", "AOED", SatelliteData.AOED);
            Helper.AddRowToDgv(dgv, "Синусный поправочный коэффициент", "Crs", SatelliteData.Crs);
            Helper.AddRowToDgv(dgv,
                "Коррекция среднего движения (отклонение от расчетного), (рад / сек)",
                "Δn", SatelliteData.delta_n);
            Helper.AddRowToDgv(dgv, "Средняя аномалия в опорную эпоху (рад)", "M0", SatelliteData.M0);
            Helper.AddRowToDgv(dgv, "Косинусный поправочный коэффициент к аргументу широты "
                + "(аргументу перигея)", "Cuc", SatelliteData.Cuc);
            Helper.AddRowToDgv(dgv, "Эксцентриситет", "e", SatelliteData.e);
            Helper.AddRowToDgv(dgv, "Синусный поправочный коэффициент к аргументу широты"
                + "(аргументу перигея)", "Cus", SatelliteData.Cus);
            Helper.AddRowToDgv(dgv, "Квадратный корень из большой полуоси в метрах", "√A", SatelliteData.sqrt_A);
            Helper.AddRowToDgv(dgv, "Опорная эпоха эфемерид (секунды недели GPS)", "toe", SatelliteData.toe);
            Helper.AddRowToDgv(dgv, "Косинусный поправочный коэффициент к наклонению", "Cic", SatelliteData.Cic);
            Helper.AddRowToDgv(dgv, "Долгота восходящего узла в опорную эпоху (на начало "
                + "недели GPS, (рад)", "Ω0", SatelliteData.Omega_0);
            Helper.AddRowToDgv(dgv, "Синусный поправочный коэффициент к наклонению", "Cis", SatelliteData.Cis);
            Helper.AddRowToDgv(dgv, "Наклонение орбиты (рад) к плоскости экватора", "i0", SatelliteData.i0);
            Helper.AddRowToDgv(dgv, "Косинусный поправочный коэффициент к геоцентрическому",
                "Crc", SatelliteData.Crc);
            Helper.AddRowToDgv(dgv, "Аргумент перигея (рад)", "ω", SatelliteData.omega);
            Helper.AddRowToDgv(dgv, "Скорость изменения долготы восходящего узла из-за "
                + "прецессии орбиты(рад / сек)", "Ω_", SatelliteData.Omega_);
            Helper.AddRowToDgv(dgv, "Cкорость изменения угла наклонения орбиты (рад/сек)", 
                "IDOT", SatelliteData.IDOT);
            Helper.AddRowToDgv(dgv, "Групповая задержка сигнала L2 в аппаратуре КС", 
                "Δtg", SatelliteData.delta_tg);
            Helper.AddRowToDgv(dgv, "Возраст обновления параметров времени (сек)",
                "AODC", SatelliteData.AODC);
            dgv.ClearSelection();
        }
    }
}
