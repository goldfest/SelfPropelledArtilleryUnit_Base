using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.MovementStrategy;
using SelfPropelledArtilleryUnit.DrawningObjects;

namespace SelfPropelledArtilleryUnit.Generics
{
    /// <summary>
    /// Параметризованный класс для набора объектов DrawningUsta
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    internal class UstaGenericCollection<T, U>
    where T : DrawningUsta
    where U : IMoveableObject
    {
        /// <summary>
        /// Ширина окна прорисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна прорисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер занимаемого объектом места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер занимаемого объектом места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 110;
        /// <summary>
        /// Набор объектов
        /// </summary>
        private readonly SetGeneric<T> _collection;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth"></param>
        /// <param name="picHeight"></param>
        public UstaGenericCollection(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _collection = new SetGeneric<T>(width * height);
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// </summary>
        /// <param name="collect"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int? operator +(UstaGenericCollection<T, U> collect, T?
        obj)
        {
            if (obj == null)
            {
                return -1;
            }
            return collect?._collection.Insert(obj);
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// </summary>
        /// <param name="collect"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static bool operator -(UstaGenericCollection<T, U> collect, int
        pos)
        {
            T? obj = collect._collection[pos];
            if (obj != null)
            {
                return collect._collection.Remove(pos);
            }
            return false;
        }
        /// <summary>
        /// Получение объекта IMoveableObject
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public U? GetU(int pos)
        {
            return (U?)_collection[pos]?.GetMoveableObject;
        }
        /// <summary>
        /// Вывод всего набора объектов
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowUsta()
        {
            Bitmap bmp = new(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp);
            DrawBackground(gr);
            DrawObjects(gr);
            return bmp;
        }
        /// <summary>
        /// Метод отрисовки фона
        /// </summary>
        /// <param name="g"></param>
        private void DrawBackground(Graphics g)
        {
            Pen pen = new(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight +
                1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j *
                    _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2 + 2 , j *
                    _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i *
                _placeSizeWidth, _pictureHeight / _placeSizeHeight * _placeSizeHeight);
            }
        }
        /// <summary>
        /// Метод прорисовки объектов
        /// </summary>
        /// <param name="g"></param>
        private void DrawObjects(Graphics g)
        {
            int c = 14;
            foreach (var usta in _collection.GetUsta())
            {
                if (usta != null)
                {

                    int index = _collection.GetUsta().ToList().IndexOf(usta);
                    if (index % 3 == 0 && index != 0)
                    {
                        c = c - 3;

                    }
                    // TODO получение объекта
                    // TODO установка позиции
                    // TODO прорисовка объекта
                    // Установка позиции объекта

                    int posX = index % (_pictureWidth / _placeSizeWidth) * _placeSizeWidth + 3;
                    int posY = c / (_pictureWidth / _placeSizeWidth) * _placeSizeHeight + 15;

                    // Прорисовка объекта
                    usta.SetPosition(posX, posY);
                    usta.DrawTransport(g);
                }
            }
        }
    }
}

