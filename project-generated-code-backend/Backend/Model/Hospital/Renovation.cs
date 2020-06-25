using Backend.Model.Util;
using Model.Hospital;
using Model.Util;
using Newtonsoft.Json;
using System;

namespace HealthClinic.Backend.Model.Hospital
{
    public class Renovation : Entity
    {
        private static int serialNumberGenerator = 0;
        private static int idMaker = 0;
        private int id;
        private TimeInterval renovationTime;


        /// <summary>
        /// Property for Room
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>

        public TimeInterval TimeInteval { get => renovationTime; set => renovationTime = value; }
        public int Id { get => id; set => id = value; }

        public Renovation(TimeInterval timeInteval) : base(Guid.NewGuid().ToString())
        {
            id = ++idMaker;
            TimeInteval = timeInteval;
        }

        [JsonConstructor]
        public Renovation(String serialNumber, TimeInterval timeInteval) : base(serialNumber)
        {
            id = ++idMaker;
            TimeInteval = timeInteval;
        }
    }
}

