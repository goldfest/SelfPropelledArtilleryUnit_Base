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
        private readonly T?[] _places;
        /// <summary>
        /// Количество объектов в массиве
        /// </summary>
        public int Count => _places.Length;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetGeneric(int count)
        {
            _places = new T?[count];
        }
        /// <summary>
        /// Добавление объекта в набор
        /// </summary>
        /// <param name="usta">Добавляемая установка</param>
        /// <returns></returns>
        public int Insert(T usta)
        {
            return Insert(usta, 0);
        }
        /// <summary>
        /// Добавление объекта в набор на конкретную позицию
        /// </summary>
        /// <param name="usta">Добавляемая установка</param>
        /// <param name="position">Позиция</param>
        /// <returns></returns>
        public int Insert(T usta, int position)
        {
            // TODO проверка позиции
            if (position < 0 && position > Count)
            {
                return -1;
            }
            if (_places[position] != null)
            {
                int d = 0;
                for (int j = 1; j < Count - position; j++)
                {
                    if (_places[position + j] == null)
                    {
                        d = position + j;
                        break;
                    }
                }
                if (d == 0)
                {
                    return -1;
                }
                for (int j = d; j > position; j--)
                {
                    _places[j] = _places[j - 1];
                }
            }
            // TODO проверка, что элемент массива по этой позиции пустой, если нет, то
            // проверка, что после вставляемого элемента в массиве есть пустой элемент
            // сдвиг всех объектов, находящихся справа от позиции до первого пустого элемента
            // TODO вставка по позиции
            _places[position] = usta;
            return position;
        }
        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Remove(int position)
        {
            // TODO проверка позиции
            // Проверка позиции
            if (position < 0 || position >= _places.Length)
            {
                // Позиция недопустима
                return false;
            }
            // TODO удаление объекта из массива, присвоив элементу массива значение null
            _places[position] = null;
            return true;
        }
        /// <summary>
        /// Получение объекта из набора по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T? Get(int position)
        {
            // TODO проверка позиции
            if (position < 0 || position >= _places.Length)
            {
                // Позиция недопустима
                return null;
            }
            return _places[position];
        }
    }
}

