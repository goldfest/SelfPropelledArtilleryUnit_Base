using SelfPropelledArtilleryUnit.DrawningObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit
{
    internal class UstaCompareByType : IComparer<DrawningUsta?>
    {
        public int Compare(DrawningUsta? x, DrawningUsta? y)
        {
            if (x == null || x.EntityUsta == null)
                throw new ArgumentNullException(nameof(x));

            if (y == null || y.EntityUsta == null)
                throw new ArgumentNullException(nameof(y));

            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            var speedCompare = x.EntityUsta.Speed.CompareTo(y.EntityUsta.Speed);

            if (speedCompare != 0)
                return speedCompare;

            return x.EntityUsta.Weight.CompareTo(y.EntityUsta.Weight);
        }
    }
}
