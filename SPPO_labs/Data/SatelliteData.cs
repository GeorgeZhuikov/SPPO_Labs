using System;

namespace SPPO_labs.Data
{
    /// <summary>
    /// Извлеченные параметры из навигационных данных
    /// </summary>
    public class SatelliteData
    {
        /// <summary>
        /// Номер спутника
        /// </summary>
        public int PRN { get; internal set; }
        /// <summary>
        /// Дата и время
        /// </summary>
        public DateTime Date { get; internal set; }
        /// <summary>
        /// Смещение времени (сек)
        /// </summary>
        public double af0 { get; internal set; }
        /// <summary>
        /// Отношение (сек/сек)
        /// </summary>
        public double af1 { get; internal set; }
        /// <summary>
        /// Ускорение (сек/сек2)
        /// </summary>
        public double af2 { get; internal set; }
        /// <summary>
        /// Коррекция среднего движения (отклонение от расчетного), (рад / сек)
        /// </summary>
        public double delta_n { get; internal set; }
        /// <summary>
        /// Эксцентриситет
        /// </summary>
        public double e { get; internal set; }
        /// <summary>
        /// Синусный поправочный коэффициент к аргументу широты (аргументу перигея)
        /// </summary>
        public double Cus { get; internal set; }
        /// <summary>
        /// Квадратный корень из большой полуоси в метрах
        /// </summary>
        public double sqrt_A { get; internal set; }
        /// <summary>
        /// Опорная эпоха эфемерид (секунды недели GPS)
        /// </summary>
        public double toe { get; internal set; }
        /// <summary>
        /// Косинусный поправочный коэффициент к наклонению
        /// </summary>
        public double Cic { get; internal set; }
        /// <summary>
        /// Долгота восходящего узла в опорную эпоху (на начало недели GPS, (рад)
        /// </summary>
        public double Omega_0 { get; internal set; }
        /// <summary>
        /// Наклонение орбиты (рад) к плоскости экватора
        /// </summary>
        public double i0 { get; internal set; }
        /// <summary>
        /// Косинусный поправочный коэффициент к геоцентрическому
        /// </summary>
        public double Crc { get; internal set; }
        /// <summary>
        /// Аргумент перигея (рад)
        /// </summary>
        public double omega { get; internal set; }
        /// <summary>
        /// Скорость изменения долготы восходящего узла из-за прецессии орбиты (рад / сек)
        /// </summary>
        public double Omega_ { get; internal set; }
        /// <summary>
        /// Cкорость изменения угла наклонения орбиты (рад/сек)
        /// </summary>
        public double IDOT { get; internal set; }
        /// <summary>
        /// Групповая задержка сигнала L2 в аппаратуре КС
        /// </summary>
        public double delta_tg { get; internal set; }
        /// <summary>
        /// Возраст обновления параметров времени (сек)
        /// </summary>
        public double AODC { get; internal set; }
        /// <summary>
        /// Синусный поправочный коэффициент к наклонению
        /// </summary>
        public double Cis { get; internal set; }
        /// <summary>
        /// Возраст эфемерид (сек)
        /// </summary>
        public double AOED { get; internal set; }
        /// <summary>
        /// Синусный поправочный коэффициент
        /// </summary>
        public double Crs { get; internal set; }
        /// <summary>
        /// Средняя аномалия в опорную эпоху (рад)
        /// </summary>
        public double M0 { get; internal set; }
        /// <summary>
        /// Косинусный поправочный коэффициент к аргументу широты (аргументу перигея)
        /// </summary>
        public double Cuc { get; internal set; }
    }
}
