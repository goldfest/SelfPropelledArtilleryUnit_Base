using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit.Generics
{
    /// <summary>
    /// Параметризованный набор объектов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class SetGeneric<T>
    where T : class

    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly List<T?> _places;
        /// <summary>
        /// Количество объектов в массиве
        /// </summary>
        public int Count => _places.Count;
        /// <summary>
        /// Максимальное количество объектов в списке
        /// </summary>
        private readonly int _maxCount;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetGeneric(int count)
        {
            _maxCount = count;
            _places = new List<T?>(count);
        }
        /// <summary>
        /// Добавление объекта в набор
        public int Insert(T usta)
        {

            return Insert(usta, 0);
        }

        /// <returns></returns>
        public int Insert(T usta, int position)
        {
            if (position < 0 || position >= _maxCount)
                return -1;

            if (Count >= _maxCount)
                return -1;



            _places.Insert(position, usta);
            return position;
        }

        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Remove(int position)
        {
            if ((position < 0) || (position > _maxCount)) return false;
            _places.RemoveAt(position);
            return true;
        }
        /// <summary>
        /// Получение объекта из набора по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns> 
        public T? this[int position]
        {
            get
            {
                if (position < 0 || position > _maxCount)
                    return null;
                return _places[position];
            }
            set
            {
                if (position < 0 || position > _maxCount)
                    return;
                _places[position] = value;
            }


        }
        /// <summary>
        /// Проход по списку
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T?> GetUsta(int? maxUsta = null)
        {
            for (int i = 0; i < _places.Count; ++i)
            {
                yield return _places[i];
                if (maxUsta.HasValue && i == maxUsta.Value)
                {
                    yield break;
                }
            }
        }
    }
}