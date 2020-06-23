using Model.Hospital;
using Model.Util;

namespace HealthClinic.Backend.Model.Hospital
{
    public class Renovation
    {
        private static int idMaker = 0;
        private int id;
        private TimeInterval renovationTime;


        /// <summary>
        /// Property for Room
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>

        public TimeInterval TimeInteval { get => renovationTime; set => renovationTime = value; }
        public int Id { get => id; set => id = value; }

        public Renovation(TimeInterval timeInteval)
        {
            id = ++idMaker;
            TimeInteval = timeInteval;
        }
    }
}

