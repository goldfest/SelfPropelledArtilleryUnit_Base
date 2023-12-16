using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit
{
    internal class UstaCollectionInfo : IEquatable<UstaCollectionInfo>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public UstaCollectionInfo(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public bool Equals(UstaCollectionInfo? other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
