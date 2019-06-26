namespace SPPO_labs.Data
{
    /// <summary>
    /// Расчётные параметры
    /// </summary>
    public class CalculateLab1Data
    {
        /// <summary>
        /// Точность расчёта уравнения Кеплера
        /// </summary>
        public double Accuracy { get { return 1E-6; } }
        /// <summary>
        /// Время обновления эфэмерид
        /// </summary>
        public double UpdateTimeSec { get { return 1800; } }
        /// <summary>
        /// Гравитационная постоянная умноженная на массу земли
        /// </summary>
        public double Mu { get { return 3.986005E14; } }
        /// <summary>
        /// Скорость света
        /// </summary>
        public double c { get { return 2.99792458E8; } }
        /// <summary>
        /// Угловая скорость вращения Земли (стандарт WGS — 84)
        /// </summary>
        public double Omega_e { get { return 7.2921151467e-5; } }
        /// <summary>
        /// Поправка на релятивистский эффект
        /// </summary>
        public double delta_tr { get; internal set; }
        /// <summary>
        /// Большая полуось орбиты навигационного спутника
        /// </summary>
        public double A { get; internal set; }
        /// <summary>
        /// Средняя угловая скорость движущейся точки
        /// </summary>
        public double n { get; internal set; }
        /// <summary>
        /// Расчётное среднее движение
        /// </summary>
        public double n0 { get; internal set; }
        /// <summary>
        /// Показания часов навигационного приемника на момент измерения в секундах от начала недели GPS
        /// </summary>
        public double t { get; internal set; }
        /// <summary>
        /// Поправка для перехода от бортовой шкалы времени к системной шкале
        /// </summary>
        public double delta_t { get; internal set; }
        /// <summary>
        /// Время излучения метки времени по системной шкале
        /// </summary>
        public double tk { get; internal set; }
        /// <summary>
        /// Средняя аномалия космического спутника
        /// </summary>
        public double Mk { get; internal set; }
        /// <summary>
        /// Эксцентрическая аномалия
        /// </summary>
        public double Ek { get; internal set; }
        /// <summary>
        /// Истинная аномалия
        /// </summary>
        public double Ypsilon { get; internal set; }
        /// <summary>
        /// Косинус истинной аномалии
        /// </summary>
        public double CosYpsilon { get; internal set; }
        /// <summary>
        /// Предварительный аргумент широты
        /// </summary>
        public double U_ { get; internal set; }
        /// <summary>
        /// Исправленный аргумент широты
        /// </summary>
        public double U { get; internal set; }
        /// <summary>
        /// Радиус-вектор навигационного спутника
        /// </summary>
        public double r { get; internal set; }
        /// <summary>
        /// Наклон возмущённой плоскости орбиты к плоскости экватора
        /// </summary>
        public double i { get; internal set; }
        /// <summary>
        /// Долгота восходящего узла
        /// </summary>
        public double lambda { get; internal set; }
        /// <summary>
        /// Координата спутника Х
        /// </summary>
        public double X { get; internal set; }
        /// <summary>
        /// Координата спутника Y
        /// </summary>
        public double Y { get; internal set; }
        /// <summary>
        /// Координата спутника Z
        /// </summary>
        public double Z { get; internal set; }
    }
}
