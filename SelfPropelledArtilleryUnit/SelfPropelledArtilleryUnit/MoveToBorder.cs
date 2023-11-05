using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit.MovementStrategy
{
    /// <summary>
    /// Стратегия перемещения объекта к границе экрана
    /// </summary>
    public class MoveToBorder : AbstractStrategy
    {
        protected override bool IsTargetDestinaion()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return false;
            }
            return objParams.RightBorder <= FieldWidth &&
                objParams.RightBorder + GetStep() >= FieldWidth &&
                objParams.DownBorder <= FieldHeight &&
                objParams.DownBorder + GetStep() >= FieldHeight;
        }




        protected override void MoveToTarget()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return;
            }
            var diffX = objParams.RightBorder - FieldWidth;
            if (Math.Abs(diffX) > GetStep())
            {
                MoveRight();
            }
            var diffY = objParams.DownBorder - FieldHeight;
            if (Math.Abs(diffY) > GetStep())
            {
                MoveDown();
            }
        }



    }
}

