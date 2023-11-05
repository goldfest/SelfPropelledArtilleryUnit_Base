using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.Entities;
namespace SelfPropelledArtilleryUnit.DrawningObjects
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение объекта-сущности
    /// </summary>
    public class DrawningUstaBat : DrawningUsta
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Основной цвет</param>
        /// <param name="additionalColor">Дополнительный цвет</param>
        /// <param name="bodyKit">Признак наличия батареи</param>
        /// <param name="pushka">Признак наличия пушки</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public DrawningUstaBat(int speed, double weight, Color bodyColor, Color
       additionalColor, bool bodyKit, bool pushka, int width, int height) :
        base(speed, weight, bodyColor, width, height, 140, 90)
        {
            if (EntityUsta_ != null)
            {
                EntityUsta_ = new EntityUstaBat(speed, weight, bodyColor,
                additionalColor, bodyKit, pushka);
            }
        }

       
        public override void DrawTransport(Graphics g)
        {
            if (EntityUsta_ is not EntityUstaBat ustaBat)
            {
                return;
            }
            Pen pen = new(Color.Black);

            Brush additionalBrush = new SolidBrush(ustaBat.AdditionalColor);
            Brush BodyColor = new SolidBrush(EntityUsta_.BodyColor);

            //зеленый темнее
            Color color1 = Color.FromArgb(65, 72, 51);
            Brush pen1 = new SolidBrush(color1);

            //black

            Color color3 = Color.FromArgb(0, 0, 0);
            Brush pen3 = new SolidBrush(color3);


            //зеленый мох
            Color color2 = Color.FromArgb(47, 69, 56);
            Brush pen2 = new SolidBrush(color1);
            // батарея
            if (ustaBat.BodyKit)
            {
                GraphicsPath path1 = new GraphicsPath();
                path1.AddLine(_startPosX + 15, _startPosY + 40, _startPosX + 15, _startPosY + 30);
                path1.AddLine(_startPosX + 15, _startPosY + 30, _startPosX + 15, _startPosY + 35);
                path1.AddLine(_startPosX + 15, _startPosY + 35, _startPosX + 25, _startPosY + 35);
                path1.AddLine(_startPosX + 25, _startPosY + 35, _startPosX + 30, _startPosY + 30);
                path1.AddLine(_startPosX + 30, _startPosY + 30, _startPosX + 35, _startPosY + 40);
                path1.CloseFigure();

                g.DrawPath(pen, path1);

                g.FillPath(BodyColor, path1);



                GraphicsPath path2 = new GraphicsPath();
                path2.AddLine(_startPosX + 15, _startPosY + 30, _startPosX + 40, _startPosY + 20);
                path2.AddLine(_startPosX + 40, _startPosY + 20, _startPosX + 40, _startPosY + 25);
                path2.AddLine(_startPosX + 40, _startPosY + 25, _startPosX + 25, _startPosY + 35);
                path2.AddLine(_startPosX + 25, _startPosY + 35, _startPosX + 15, _startPosY + 35);

                path2.CloseFigure();

                g.DrawPath(pen, path2);

                g.FillPath(additionalBrush, path2);



                GraphicsPath path3 = new GraphicsPath();
                path3.AddLine(_startPosX + 10, _startPosY + 32, _startPosX, _startPosY + 10);
                path3.AddLine(_startPosX, _startPosY + 10, _startPosX + 40, _startPosY - 7);
                path3.AddLine(_startPosX + 40, _startPosY - 7, _startPosX + 50, _startPosY + 16);

                path3.CloseFigure();

                g.DrawPath(pen, path3);

                g.FillPath(pen3, path3);



                GraphicsPath path4 = new GraphicsPath();
                path4.AddLine(_startPosX, _startPosY + 10, _startPosX + 40, _startPosY - 7);
                path4.AddLine(_startPosX + 40, _startPosY - 7, _startPosX + 43, _startPosY - 5);
                path4.AddLine(_startPosX + 43, _startPosY - 5, _startPosX + 41, _startPosY - 3);
                path4.AddLine(_startPosX + 41, _startPosY - 3, _startPosX + 2, _startPosY + 13);

                path4.CloseFigure();

                g.DrawPath(pen, path4);

                g.FillPath(additionalBrush, path4);


                GraphicsPath path5 = new GraphicsPath();
                path5.AddLine(_startPosX + 3, _startPosY + 15, _startPosX + 45, _startPosY - 2);
                path5.AddLine(_startPosX + 46, _startPosY - 2, _startPosX + 49, _startPosY - 1);
                path5.AddLine(_startPosX + 49, _startPosY - 1, _startPosX + 46, _startPosY + 3);
                path5.AddLine(_startPosX + 46, _startPosY + 3, _startPosX + 6, _startPosY + 20);

                path5.CloseFigure();

                g.DrawPath(pen, path5);

                g.FillPath(BodyColor, path5);



                GraphicsPath path6 = new GraphicsPath();
                path6.AddLine(_startPosX + 5, _startPosY + 22, _startPosX + 47, _startPosY + 5);
                path6.AddLine(_startPosX + 47, _startPosY + 5, _startPosX + 51, _startPosY + 5);
                path6.AddLine(_startPosX + 51, _startPosY + 5, _startPosX + 53, _startPosY + 7);
                path6.AddLine(_startPosX + 53, _startPosY + 7, _startPosX + 8, _startPosY + 25);

                path6.CloseFigure();

                g.DrawPath(pen, path6);

                g.FillPath(additionalBrush, path6);


                GraphicsPath path7 = new GraphicsPath();
                path7.AddLine(_startPosX + 7, _startPosY + 27, _startPosX + 46, _startPosY + 11);
                path7.AddLine(_startPosX + 46, _startPosY + 11, _startPosX + 51, _startPosY + 9);
                path7.AddLine(_startPosX + 51, _startPosY + 9, _startPosX + 56, _startPosY + 11);
                path7.AddLine(_startPosX + 56, _startPosY + 11, _startPosX + 10, _startPosY + 31);

                path7.CloseFigure();

                g.DrawPath(pen, path7);

                g.FillPath(BodyColor, path7);
            }
            base.DrawTransport(g);
            // пушка
            if (ustaBat.Pushka)
            {
                g.FillRectangle(pen2, _startPosX + 80, _startPosY + 25, 10, 10);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 25, 10, 10);

                g.FillRectangle(additionalBrush, _startPosX + 90, _startPosY + 28, 40, 5);
                g.DrawRectangle(pen, _startPosX + 90, _startPosY + 28, 40, 5);

                g.FillRectangle(additionalBrush, _startPosX + 130, _startPosY + 27, 5, 7);
                g.DrawRectangle(pen, _startPosX + 130, _startPosY + 27, 5, 7);
            }

        }
    }
}
