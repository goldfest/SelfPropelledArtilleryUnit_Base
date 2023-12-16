using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit
{
    internal class DrawningUstaEqutables : IEqualityComparer<DrawningUsta?>
    {
        public bool Equals(DrawningUsta? x, DrawningUsta? y)
        {
            if (x == null || x.EntityUsta == null)
            {
                throw new ArgumentNullException(nameof(x));
            }
            if (y == null || y.EntityUsta == null)
            {
                throw new ArgumentNullException(nameof(y));
            }
            if (x.GetType().Name != y.GetType().Name)
            {
                return false;
            }
            if (x.EntityUsta.Speed != y.EntityUsta.Speed)
            {
                return false;
            }
            if (x.EntityUsta.Weight != y.EntityUsta.Weight)
            {
                return false;
            }
            if (x.EntityUsta.BodyColor != y.EntityUsta.BodyColor)
            {
                return false;
            }
            if (x is EntityUstaBat && y is EntityUstaBat)
            {
                EntityUstaBat EntityX = (EntityUstaBat)x.EntityUsta;
                EntityUstaBat EntityY = (EntityUstaBat)y.EntityUsta;
                if (EntityX.AdditionalColor != EntityY.AdditionalColor)
                    return false;
                if (EntityX.Pushka != EntityY.Pushka)
                    return false;
                if (EntityX.BodyKit != EntityY.BodyKit)
                    return false;
            }
            return true;
        }

        public int GetHashCode([DisallowNull] DrawningUsta obj)
        {
            return obj.GetHashCode();
        }
    }
}
