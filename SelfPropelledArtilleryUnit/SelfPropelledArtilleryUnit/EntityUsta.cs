using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit.Entities
{
    /// <summary>
    /// Класс-сущность "Установка"
    /// </summary>
    public class EntityUsta
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; private set; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color BodyColor { get; private set; }
        /// <summary>
        /// Шаг перемещения установки
        /// </summary>
        public double Step => (double)Speed * 100 / Weight;
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес установки</param>
        /// <param name="bodyColor">Основной цвет</param>
        public EntityUsta(int speed, double weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
        }
    }
}

