using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SelfPropelledArtilleryUnit.Entities;
using SelfPropelledArtilleryUnit.Drawnings;
using System.Drawing.Drawing2D;
using SelfPropelledArtilleryUnit.MovementStrategy;

namespace SelfPropelledArtilleryUnit.DrawningObjects
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение объекта-сущности
    /// </summary>
    public class DrawningUsta
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public EntityUsta? EntityUsta { get; protected set; }
        /// <summary>
        /// Ширина окна
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Левая координата прорисовки установки
        /// </summary>
        protected int _startPosX;
        /// <summary>
        /// Верхняя кооридната прорисовки установки
        /// </summary>
        protected int _startPosY;
        /// <summary>
        /// Ширина прорисовки установки
        /// </summary>
        protected readonly int _ustaWidth = 140;
        /// <summary>
        /// Высота прорисовки установки
        /// </summary>
        protected readonly int _ustaHeight = 90;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Основной цвет</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public DrawningUsta(int speed, double weight, Color bodyColor, int
        width, int height)
        {
            // TODO: Продумать проверки
            _pictureWidth = width;
            _pictureHeight = height;
            EntityUsta = new EntityUsta(speed, weight, bodyColor);
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Основной цвет</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        /// <param name="carWidth">Ширина прорисовки установки</param>
        /// <param name="carHeight">Высота прорисовки установки</param>
        protected DrawningUsta(int speed, double weight, Color bodyColor, int
        width, int height, int ustaWidth, int ustaHeight)
        {
            // TODO: Продумать проверки
            if (width <= _pictureWidth || height <= _pictureHeight)
            {
                return;
            }
            
            _pictureWidth = width;
            _pictureHeight = height;
            _ustaWidth = ustaWidth;
            _ustaHeight = ustaHeight;
            EntityUsta = new EntityUsta(speed, weight, bodyColor);
        }
        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public void SetPosition(int x, int y)
        {
            // TODO: Изменение x, y, если при установке объект выходит за границы
            if (x < 0 || y < 0)
            {
                x = 10;
                y = 10;
            }
            _startPosX = x;
            _startPosY = y;
            
        }

        /// <summary>
        /// Получение объекта IMoveableObject из объекта DrawningUsta
        /// </summary>
        public IMoveableObject GetMoveableObject => new DrawningObjectUsta(this);

        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>

        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        /// <param name="g"></param>
        /// <summary>
        /// Координата X объекта
        /// </summary>
        public int GetPosX => _startPosX;
        /// <summary>
        /// Координата Y объекта
        /// </summary>
        public int GetPosY => _startPosY;
        /// <summary>
        /// Ширина объекта
        /// </summary>
        public int GetWidth => _ustaWidth;
        /// <summary>
        /// Высота объекта
        /// </summary>
        public int GetHeight => _ustaHeight;

        /// <summary>
        /// Проверка, что объект может переместится по указанному направлению
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <returns>true - можно переместится по указанному направлению</returns>
        public virtual bool CanMove(DirectionType direction)
        {
            if (EntityUsta == null)
            {
                return false;
            }
            return direction switch
            {
                //влево
                DirectionType.Left => _startPosX - EntityUsta.Step > 0,
                //вверх
                DirectionType.Up => _startPosY - EntityUsta.Step > 7,
                // вправо
                DirectionType.Right => _startPosX + EntityUsta.Step + _ustaWidth < _pictureWidth,// TODO: Продумать логику
                //вниз
                DirectionType.Down => _startPosY + EntityUsta.Step + _ustaHeight < _pictureHeight,// TODO: Продумать логику
                _ => false,
            };
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public virtual void MoveTransport(DirectionType direction)
        {
            
            if (!CanMove(direction) || EntityUsta == null)
            {
                return;
            }
            switch (direction)
            {
                case DirectionType.Left:
                    _startPosX -= (int)EntityUsta.Step;
                    break;
                case DirectionType.Up:
                    _startPosY -= (int)EntityUsta.Step;
                    break;
                case DirectionType.Right:
                    _startPosX += (int)EntityUsta.Step;
                    break;
                case DirectionType.Down:
                    _startPosY += (int)EntityUsta.Step;
                    break;
            }
        }

        public virtual void DrawTransport(Graphics g)
        {
            if (EntityUsta == null)
            {
                return;
            }
            Pen pen = new(Color.Black);

            
            Brush BodyColor = new SolidBrush(EntityUsta.BodyColor);

            //зеленый темнее
            int lineWidth = 10;
            Color color1 = Color.FromArgb(65, 72, 51);
            Brush pen1 = new SolidBrush(color1);

            //black

            Color color3 = Color.FromArgb(0, 0, 0);
            Brush pen3 = new SolidBrush(color3);


            //зеленый мох
            Color color2 = Color.FromArgb(47, 69, 56);
            Brush pen2 = new SolidBrush(color1);


            //прорисовка арт. установки

            int cornerRadius = 16; // Радиус скругления углов
            int cornerRadius1 = 12;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(_startPosX + 5, _startPosY + 50, 2 * cornerRadius1, 2 * cornerRadius1, 180, 90); // Верхний левый угол
            path.AddArc(_startPosX + 110, _startPosY + 50, 2 * cornerRadius1, 2 * cornerRadius1, 270, 90); // Верхний правый угол
            path.AddArc(_startPosX + 110, _startPosY + 50, 2 * cornerRadius1, 2 * cornerRadius, 0, 90); // Нижний правый угол
            path.AddArc(_startPosX + 5, _startPosY + 50, 2 * cornerRadius, 2 * cornerRadius, 90, 90); // Нижний левый угол
            path.CloseFigure(); // Замкнуть путь

            // отрисовка прямоугольника с кругленными краями
            g.FillPath(BodyColor, path);
            g.DrawPath(pen, path);


            g.FillEllipse(pen3, _startPosX + 47, _startPosY + 44, 13, 13);
            g.FillEllipse(pen3, _startPosX + 62, _startPosY + 44, 13, 13);
            g.FillEllipse(pen3, _startPosX + 77, _startPosY + 44, 13, 13);


            g.FillRectangle(BodyColor, _startPosX + 45, _startPosY + 20, 40, 20);
            g.DrawRectangle(pen, _startPosX + 45, _startPosY + 20, 40, 20);

            g.DrawEllipse(pen, _startPosX + 40, _startPosY + 65, 13, 13);
            g.DrawEllipse(pen, _startPosX + 55, _startPosY + 65, 13, 13);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY + 65, 13, 13);
            g.DrawEllipse(pen, _startPosX + 85, _startPosY + 65, 13, 13);

            g.FillRectangle(BodyColor, _startPosX + 10, _startPosY + 40, 120, 10);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 40, 120, 10);

            g.FillEllipse(pen3, _startPosX + 10, _startPosY + 52, 26, 26);
            g.FillEllipse(pen3, _startPosX + 105, _startPosY + 52, 26, 26);
        }
    }
}

