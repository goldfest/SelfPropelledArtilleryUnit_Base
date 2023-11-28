using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SelfPropelledArtilleryUnit.Exceptions
{
    [Serializable] internal class UstaNotFoundException : ApplicationException
    {
        public UstaNotFoundException(int i) : base($"Не найден объект по позиции {i}") { }
        public UstaNotFoundException() : base() { }
        public UstaNotFoundException(string message) : base(message) { }
        public UstaNotFoundException(string message, Exception exception) : base(message, exception) { }
        protected UstaNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}

