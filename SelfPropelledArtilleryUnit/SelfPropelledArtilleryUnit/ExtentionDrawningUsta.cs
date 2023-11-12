using SelfPropelledArtilleryUnit.Entities;
namespace SelfPropelledArtilleryUnit.DrawningObjects
{
    /// <summary>
    /// Расширение для класса EntityUsta
    /// </summary>
    public static class ExtentionDrawningUsta
    {
        /// <summary>
        /// Создание объекта из строки
        /// </summary>
        /// <param name="info">Строка с данными для создания объекта</param>
        /// <param name="separatorForObject">Разделитель даннных</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <returns>Объект</returns>
        public static DrawningUsta? CreateDrawningUsta(this string info, char
        separatorForObject, int width, int height)
        {
            string[] strs = info.Split(separatorForObject);
            if (strs.Length == 3)
            {
                return new DrawningUsta(Convert.ToInt32(strs[0]),
                Convert.ToInt32(strs[1]), Color.FromName(strs[2]), width, height);
            }
            else if (strs.Length == 6)
            {
                return new DrawningUstaBat(Convert.ToInt32(strs[0]),
                Convert.ToInt32(strs[1]),
                Color.FromName(strs[2]),
                Color.FromName(strs[3]),
                Convert.ToBoolean(strs[4]),
                Convert.ToBoolean(strs[5]), width, height);
            }
            return null;
        }
        /// <summary>
        /// Получение данных для сохранения в файл
        /// </summary>
        /// <param name="drawningUsta">Сохраняемый объект</param>
        /// <param name="separatorForObject">Разделитель даннных</param>
        /// <returns>Строка с данными по объекту</returns>
        public static string GetDataForSave(this DrawningUsta drawningUsta,
        char separatorForUsta)
        {
            var usta = drawningUsta.EntityUsta;
            if (usta == null)
            {
                return string.Empty;
            }
            var str =
            $"{usta.Speed}{separatorForUsta}{usta.Weight}{separatorForUsta}{usta.BodyColor.Name}";
            if (usta is not EntityUstaBat sportUsta)
            {
                return str;
            }
            return $"{str}{separatorForUsta}{sportUsta.AdditionalColor.Name}{separatorForUsta}{sportUsta.BodyKit}{separatorForUsta}{sportUsta.Pushka}";
        }
    }
}

