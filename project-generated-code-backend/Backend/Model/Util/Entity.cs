using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Model.Util
{
    public abstract class Entity
    {
        private int serialNumber;
        public int SerialNumber { get => serialNumber; }

        [JsonConstructor]
        public Entity(int serialNumber)
        {
            this.serialNumber = serialNumber;
        }
    }
}
