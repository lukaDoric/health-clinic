using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Model.Util
{
    public abstract class Entity
    {
        private string serialNumber;
        public string SerialNumber { get => serialNumber; }

        [JsonConstructor]
        public Entity(string serialNumber)
        {
            this.serialNumber = serialNumber;
        }
    }
}
