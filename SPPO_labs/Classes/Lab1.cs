using SPPO_labs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPO_labs.Classes
{
    class Lab1
    {
        /// <summary>
        /// Извлеченные параметры из навигационных данных
        /// </summary>
        private SatelliteData _sd;
        /// <summary>
        /// Расчётные параметры
        /// </summary>
        private CalculateLab1Data _cld;

        private string[] GetData(string text)
        {
            var data = text.Replace("-", " -")
                .Replace("D ", "D")
                .Replace("D", "E").Split(' ');
            List<string> newData = new List<string>();
            foreach (var note in data)
                if (note != "")
                    newData.Add(note.Trim().Replace(".",",").Replace("\n", "")
                        .Replace("\r", ""));
            return newData.ToArray();
        }

        private void AddRow(DataGridView dgv, string text, string sign,object value)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = dgv.RowCount + 1 });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = text });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = sign });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = value });
            dgv.Rows.Add(row);
        }

        private void PreCalculation()
        {
            _cld.delta_tr = 0;
            _cld.A = Math.Pow(_sd.sqrt_A, 2);
            _cld.n0 = Math.Sqrt(_cld.Mu / Math.Pow(_cld.A, 3));
            _cld.n = _cld.n0 + _sd.delta_n;
            _cld.Mk = _sd.M0 + _cld.n * _cld.tk;
        }

        private void CalculateTime()
        {
            _cld.t = _sd.toe + _cld.UpdateTimeSec;
            _cld.delta_t = _sd.af0 + _sd.af1 * _cld.UpdateTimeSec
                + _sd.af2 * Math.Pow(_cld.UpdateTimeSec, 2) + _cld.delta_tr;
            _cld.tk = _cld.t - _cld.delta_t - _sd.toe;
        }

        private double EkIteration()
        {
            double latestEk = _cld.Ek;
            CalculateTime();
            _cld.Ek = _cld.Mk + (_sd.e - Math.Pow(_sd.e, 3.0 / 8)) * Math.Sin(_cld.Mk)
                + Math.Pow(_sd.e, 2) * Math.Sin(2 * _cld.Mk) / 2
                + 3 * Math.Pow(_sd.e, 3.0 / 8) * Math.Sin(3 * _cld.Mk);
            _cld.Ek += (_sd.e * Math.Sin(_cld.Ek) + _cld.Mk - _cld.Ek)
                / (1 - _sd.e * Math.Sin(_cld.Ek));
            _cld.delta_tr = -2 * Math.Sqrt(_cld.Mu) * _sd.e * _sd.sqrt_A
                * Math.Sin(_cld.Ek) / Math.Pow(_cld.c, 2);
            return latestEk;
        }

        private void CalculateFinalCoord()
        {
            _cld.CosYpsilon = (Math.Cos(_cld.Ek) - _sd.e) 
                / (1 - _sd.e * Math.Cos(_cld.Ek));
            //double sinYpsilon = (Math.Sqrt(1 - Math.Pow(_sd.e, 2)) * Math.Sin(_cld.Ek))
            //    / (1 - _sd.e * Math.Cos(_cld.Ek));
            _cld.Ypsilon = Math.Acos(_cld.CosYpsilon) + 1.5 * Math.PI;
            //double Y = Math.Asin(sinYpsilon) + 1.5 * Math.PI;
            double U_ = _cld.Ypsilon + _sd.omega;
            _cld.U = U_ + _sd.Cus * Math.Sin(2 * U_) + _sd.Cuc * Math.Cos(2 * U_);
            _cld.r = _cld.A * (1 - _sd.e * Math.Cos(_cld.Ek))
                + _sd.Crs * Math.Sin(2 * _cld.U)
                + _sd.Crc * Math.Cos(2 * _cld.U);
            _cld.i = _sd.i0 + _sd.Cis * Math.Sin(2 * _cld.U)
                + _sd.Cic * Math.Cos(2 * _cld.U)
                + _sd.IDOT * _cld.tk;
            double x_ = _cld.r * Math.Cos(_cld.U);
            double y_ = _cld.r * Math.Sin(_cld.U);
            _cld.lambda = _sd.Omega_0 + (_sd.Omega_ - _cld.Omega_e) * _cld.tk
                - _cld.Omega_e * _sd.toe;
            _cld.X = x_ * Math.Cos(_cld.lambda) 
                - y_ * Math.Cos(_cld.i) * Math.Sin(_cld.lambda);
            _cld.Y = x_ * Math.Sin(_cld.lambda)
                + y_ * Math.Cos(_cld.i) * Math.Cos(_cld.lambda);
            _cld.Z = y_ * Math.Cos(_cld.i);
        }

        private void ShowResult(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Rows.Clear();
            AddRow(dgv, "Время излучения метки времени по системной шкале", 
                "tk", _cld.tk);
            AddRow(dgv, "Поправка для перехода от бортовой шкалы времени к системной"
                + " шкале", "Δt", _cld.delta_t);
            AddRow(dgv, "Поправка на релятивистский эффект", "Δtr", _cld.delta_tr);
            AddRow(dgv, "Координта спутника Х", "Х", _cld.X);
            AddRow(dgv, "Координта спутника Y", "Y", _cld.Y);
            AddRow(dgv, "Координта спутника Z", "Z", _cld.Z);
            dgv.ClearSelection();
        }

        internal void CalculateCoordAndSystemTime(DataGridView dgv)
        {
            PreCalculation();
            EkIteration();
            for (;Math.Abs(_cld.Ek - EkIteration()) > _cld.Accuracy;) { }
            CalculateFinalCoord();
            ShowResult(dgv);
        }

        internal void Parse(string text)
        {
            _sd = new SatelliteData();
            _cld = new CalculateLab1Data();
            var data = GetData(text);
            int index = 0;
            _sd.PRN = Convert.ToInt32(data[index++]);
            _sd.Date = new DateTime(
                Convert.ToInt32(data[index++]) + 2000,
                Convert.ToInt32(data[index++]),
                Convert.ToInt32(data[index++]), 
                Convert.ToInt32(data[index++]),
                Convert.ToInt32(data[index++]), 
                (int)Convert.ToDouble(data[index++]));
            _sd.af0 = Convert.ToDouble(data[index++]);
            _sd.af1 = Convert.ToDouble(data[index++]);
            _sd.af2 = Convert.ToDouble(data[index++]);
            _sd.AOED = Convert.ToDouble(data[index++]);
            _sd.Crs = Convert.ToDouble(data[index++]);
            _sd.delta_n = Convert.ToDouble(data[index++]);
            _sd.M0 = Convert.ToDouble(data[index++]);
            _sd.Cuc = Convert.ToDouble(data[index++]);
            _sd.e = Convert.ToDouble(data[index++]);
            _sd.Cus = Convert.ToDouble(data[index++]);
            _sd.sqrt_A = Convert.ToDouble(data[index++]);
            _sd.toe = Convert.ToDouble(data[index++]);
            _sd.Cic = Convert.ToDouble(data[index++]);
            _sd.Omega_0 = Convert.ToDouble(data[index++]);
            _sd.Cis = Convert.ToDouble(data[index++]);
            _sd.i0 = Convert.ToDouble(data[index++]);
            _sd.Crc = Convert.ToDouble(data[index++]);
            _sd.omega = Convert.ToDouble(data[index++]);
            _sd.Omega_ = Convert.ToDouble(data[index++]);
            _sd.IDOT = Convert.ToDouble(data[index++]);
            index = 32;
            _sd.delta_tg = Convert.ToDouble(data[index++]);
            _sd.AODC = Convert.ToDouble(data[index++]);
        }

        internal void ShowData(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Rows.Clear();
            AddRow(dgv, "Номер спутника", "PRN", _sd.PRN);
            AddRow(dgv, "Дата и время", "Date", _sd.Date);
            AddRow(dgv, "Смещение времени (сек)", "af0", _sd.af0);
            AddRow(dgv, "Отношение (сек/сек)", "af1", _sd.af1);
            AddRow(dgv, "Ускорение (сек/сек2)", "af2", _sd.af2);
            AddRow(dgv, "Возраст эфемерид (сек)", "AOED", _sd.AOED);
            AddRow(dgv, "Синусный поправочный коэффициент", "Crs", _sd.Crs);
            AddRow(dgv,
                "Коррекция среднего движения (отклонение от расчетного), (рад / сек)",
                "Δn", _sd.delta_n);
            AddRow(dgv, "Средняя аномалия в опорную эпоху (рад)", "M0", _sd.M0);
            AddRow(dgv, "Косинусный поправочный коэффициент к аргументу широты "
                + "(аргументу перигея)", "Cuc", _sd.Cuc);
            AddRow(dgv, "Эксцентриситет", "e", _sd.e);
            AddRow(dgv, "Синусный поправочный коэффициент к аргументу широты"
                + "(аргументу перигея)", "Cus", _sd.Cus);
            AddRow(dgv, "Квадратный корень из большой полуоси в метрах", "√A", _sd.sqrt_A);
            AddRow(dgv, "Опорная эпоха эфемерид (секунды недели GPS)", "toe", _sd.toe);
            AddRow(dgv, "Косинусный поправочный коэффициент к наклонению", "Cic", _sd.Cic);
            AddRow(dgv, "Долгота восходящего узла в опорную эпоху (на начало "
                + "недели GPS, (рад)", "Ω0", _sd.Omega_0);
            AddRow(dgv, "Синусный поправочный коэффициент к наклонению", "Cis", _sd.Cis);
            AddRow(dgv, "Наклонение орбиты (рад) к плоскости экватора", "i0", _sd.i0);
            AddRow(dgv, "Косинусный поправочный коэффициент к геоцентрическому",
                "Crc", _sd.Crc);
            AddRow(dgv, "Аргумент перигея (рад)", "ω", _sd.omega);
            AddRow(dgv, "Скорость изменения долготы восходящего узла из-за "
                + "прецессии орбиты(рад / сек)", "Ω_", _sd.Omega_);
            AddRow(dgv, "Cкорость изменения угла наклонения орбиты (рад/сек)", 
                "IDOT", _sd.IDOT);
            AddRow(dgv, "Групповая задержка сигнала L2 в аппаратуре КС", 
                "Δtg", _sd.delta_tg);
            AddRow(dgv, "Возраст обновления параметров времени (сек)",
                "AODC", _sd.AODC);
            dgv.ClearSelection();
        }
    }
}
