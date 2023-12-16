using SelfPropelledArtilleryUnit.Exceptions;
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
        public void SortSet(IComparer<T?> comparer) => _places.Sort(comparer);
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetGeneric(int count)
        {
            _maxCount = count;
            _places = new List<T?>(_maxCount);
        }
        /// <summary>
        /// Добавление объекта в набор
        public bool Insert(T usta, IEqualityComparer<T>? equal = null)
        {
            Insert(usta, 0, equal);
            return true;
        }

        /// <returns></returns>
        public bool Insert(T usta, int position, IEqualityComparer<T>? equal = null)
        {
            if (position < 0 || position >= _maxCount)
                throw new UstaNotFoundException(position);

            if (Count >= _maxCount)
                throw new StorageOverflowException(position);
            if (equal != null)
            {
                if (_places.Contains(usta, equal))
                    throw new ArgumentException(nameof(usta));
            }
            _places.Insert(position, usta);
            return true;
        }

        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Remove(int position)
        {
            if (position < 0 || position > _maxCount || position >= Count)
                throw new UstaNotFoundException();
            if (_places[position] == null)
            {
                throw new UstaNotFoundException();
            }
            _places[position] = null;
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