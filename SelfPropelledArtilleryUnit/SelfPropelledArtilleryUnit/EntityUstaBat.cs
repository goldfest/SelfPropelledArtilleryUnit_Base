using System;

namespace SelfPropelledArtilleryUnit.Entities
{
    /// <summary>
    /// Класс-сущность "Установка с вооружением"
    /// </summary>
    public class EntityUstaBat : EntityUsta
    {
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
        /// Инициализация полей объекта-класса установки с вооружением
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес установки</param>
        /// <param name="bodyColor">Основной цвет</param>
        /// <param name="additionalColor">Дополнительный цвет</param>
        /// <param name="pushka">Признак наличия пушки</param>
        /// <param name="bodyKit">Признак наличия батареи</param>
        public EntityUstaBat(int speed, double weight, Color bodyColor, Color additionalColor, bool bodyKit, bool pushka)
            : base(speed, weight, bodyColor)
        {
            AdditionalColor = additionalColor;
            BodyKit = bodyKit;
            Pushka = pushka;
        }
    }
}
