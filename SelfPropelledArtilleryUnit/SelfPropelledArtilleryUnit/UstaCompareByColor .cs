using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Entities;
using SelfPropelledArtilleryUnit.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit
{
    internal class UstaCompareByColor : IComparer<DrawningUsta?>
    {
        public int Compare(DrawningUsta? x, DrawningUsta? y)
        {
            if (x == null || x.EntityUsta == null)
                throw new ArgumentNullException(nameof(x));

            if (y == null || y.EntityUsta == null)
                throw new ArgumentNullException(nameof(y));

            if (x.EntityUsta.BodyColor.Name != y.EntityUsta.BodyColor.Name)
            {
                return x.EntityUsta.BodyColor.Name.CompareTo(y.EntityUsta.BodyColor.Name);
            }
            if (x.GetType().Name != y.GetType().Name)
            {
                if (x is EntityUsta)
                    return -1;
                else
                    return 1;
            }
            if (x.GetType().Name == y.GetType().Name && x is DrawningUstaBat)
            {
                EntityUstaBat EntityX = (EntityUstaBat)x.EntityUsta;
                EntityUstaBat EntityY = (EntityUstaBat)y.EntityUsta;
                if (EntityX.AdditionalColor.Name != EntityY.AdditionalColor.Name)
                {
                    return EntityX.AdditionalColor.Name.CompareTo(EntityY.AdditionalColor.Name);
                }
            }
            var speedCompare = x.EntityUsta.Speed.CompareTo(y.EntityUsta.Speed);

            if (speedCompare != 0)
                return speedCompare;

            return x.EntityUsta.Weight.CompareTo(y.EntityUsta.Weight);
        }
    }
}
