namespace SPPO_labs.Data
{
    public class CalculateLab2Data
    {
        /// <summary>
        /// Производная истинной аномалии
        /// </summary>
        public double _v { get; internal set; }
        /// <summary>
        /// Производная параметров коррекции аргумента широты
        /// </summary>
        public double _delta_u { get; internal set; }
        /// <summary>
        /// Производная параметров коррекции аргумента радиуса
        /// </summary>
        public double _delta_r { get; internal set; }
        /// <summary>
        /// Производная параметров коррекции аргумента угла наклона орбиты
        /// </summary>
        public double _delta_i { get; internal set; }
        /// <summary>
        /// Модуль радиальной составляющей скорости спутника
        /// </summary>
        public double v_r { get; internal set; }
        /// <summary>
        /// Модуль трансверсальной составляющей скорости спутника
        /// </summary>
        public double v_u { get; internal set; }
        /// <summary>
        /// Компонент вектора угловой скорости движения спутника в орбитальной системе координат
        /// </summary>
        public double v_1_ { get; internal set; }
        /// <summary>
        /// Компонент вектора угловой скорости движения спутника в орбитальной системе координат
        /// </summary>
        public double v_2_ { get; internal set; }
        /// <summary>
        /// Компонент вектора угловой скорости движения спутника в орбитальной системе координат
        /// </summary>
        public double v_3_ { get; internal set; }
        /// <summary>
        /// Компонент вектора абсолютной скорости движения спутника в орбитальной системе координат
        /// </summary>
        public double v_1 { get; internal set; }
        /// <summary>
        /// Компонент вектора абсолютной скорости движения спутника в орбитальной системе координат
        /// </summary>
        public double v_2 { get; internal set; }
        /// <summary>
        /// Компонент вектора абсолютной скорости движения спутника в орбитальной системе координат
        /// </summary>
        public double v_3 { get; internal set; }
        /// <summary>
        /// Компонент вектора относительной скорости навигационного спутника в гринвичской систем координат
        /// </summary>
        public double v_x { get; internal set; }
        /// <summary>
        /// Компонент вектора относительной скорости навигационного спутника в гринвичской систем координат
        /// </summary>
        public double v_y { get; internal set; }
        /// <summary>
        /// Компонент вектора относительной скорости навигационного спутника в гринвичской систем координат
        /// </summary>
        public double v_z { get; internal set; }
    }
}
