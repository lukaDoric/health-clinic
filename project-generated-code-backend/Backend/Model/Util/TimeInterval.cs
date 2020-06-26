// File:    TimeInterval.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class TimeInterval

using Newtonsoft.Json;
using System;

namespace Model.Util
{
    public class TimeInterval
    {
        private DateTime start;
        private DateTime end;

        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }

        [JsonConstructor]
        public TimeInterval(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
        }
        public TimeInterval(string start, string end)
        {
            try
            {
                this.start = Convert.ToDateTime(start);
                this.end = Convert.ToDateTime(end);
            }
            catch
            {

            }

        }

        public override string ToString()
        {
            return "start: " + start.ToString("dd.MM.yyyy. HH:mm") + "\nend: " + end.ToString("dd.MM.yyyy. HH:mm");
        }

        public override bool Equals(object obj)
        {
            TimeInterval other = obj as TimeInterval;
            if(other == null)
            {
                return false;
            }
            return this.start.Equals(other.start) && this.end.Equals(other.end);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal string ToStringHours()
        {
            return "start: " + start.ToString("HH:mm") + "\nend: " + end.ToString("HH:mm");
        }
    }
}