using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Drawnings;

namespace SelfPropelledArtilleryUnit.MovementStrategy
{
    /// <summary>
    /// Реализация интерфейса IDrawningObject для работы с объектом DrawningCar (паттерн Adapter)
/// </summary>
    public class DrawningObjectUsta : IMoveableObject
    {
        private readonly DrawningUsta? _drawningUsta = null;
        public DrawningObjectUsta(DrawningUsta drawningUsta)
        {
            _drawningUsta = drawningUsta;
        }
        public ObjectParameters? GetObjectPosition
        {
            get
            {
                if (_drawningUsta == null || _drawningUsta.EntityUsta_ ==
                null)
                {
                    return null;
                }
                return new ObjectParameters(_drawningUsta.GetPosX,
                _drawningUsta.GetPosY, _drawningUsta.GetWidth, _drawningUsta.GetHeight);
            }
        }
        public int GetStep => (int)(_drawningUsta?.EntityUsta_?.Step ?? 0);
        public bool CheckCanMove(DirectionType direction) =>
        _drawningUsta?.CanMove(direction) ?? false;
        public void MoveObject(DirectionType direction) =>
        _drawningUsta?.MoveTransport(direction);
        public void SetPosition(int x, int y)
        {
            if (_drawningUsta != null)
            {
                _drawningUsta.SetPosition(x, y);
            }
        }

        public void Draw(Graphics g)
        {
            if (_drawningUsta != null)
            {
                _drawningUsta.DrawTransport(g);
            }
        }
    }
}
