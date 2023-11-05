using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit
{
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
            /// Дополнительный цвет (для опциональных элементов)
            /// </summary>
            public Color AdditionalColor { get; private set; }
            /// <summary>
            /// Признак (опция) наличия батареи
            /// </summary>
            public bool BodyKit { get; private set; }
            /// <summary>
            /// Признак (опция) наличия пушки
            /// </summary>
            public bool Pushka { get; private set; }
            /// <summary>
            /// Шаг перемещения установки
            /// </summary>
            public double Step => (double)Speed * 100 / Weight;
            /// <summary>
            /// Инициализация полей объекта-класса установки с пушкой
            /// </summary>
            /// <param name="speed">Скорость</param>
            /// <param name="weight">Вес установки</param>
            /// <param name="bodyColor">Основной цвет</param>
            /// <param name="additionalColor">Дополнительный цвет</param>
            /// <param name="bodyKit">Признак наличия батареи</param>
            /// <param name="pushka">Признак наличия пушки</param>
            public void Init(int speed, double weight, Color bodyColor, Color
            additionalColor, bool bodyKit, bool pushka)
            {
                Speed = speed;
                Weight = weight;
                BodyColor = bodyColor;
                AdditionalColor = additionalColor;
                BodyKit = bodyKit;
                Pushka = pushka;
            }
        }

}


