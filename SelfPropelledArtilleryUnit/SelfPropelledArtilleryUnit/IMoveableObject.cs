using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SelfPropelledArtilleryUnit.Drawnings;
namespace SelfPropelledArtilleryUnit.MovementStrategy
{
    /// <summary>
    /// Интерфейс для работы с перемещаемым объектом
    /// </summary>
    public interface IMoveableObject
    {
        /// <summary>
        /// Получение координаты X объекта
        /// </summary>
        ObjectParameters? GetObjectPosition { get; }
        /// <summary>
        /// Шаг объекта
        /// </summary>
        int GetStep { get; }
        /// <summary>
        /// Проверка, можно ли переместиться по нужному направлению
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool CheckCanMove(DirectionType direction);
        /// <summary>
        /// Изменение направления пермещения объекта
        /// </summary>
        /// <param name="direction">Направление</param>
        void MoveObject(DirectionType direction);
    }
}

