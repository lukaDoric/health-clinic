// File:    Country.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Country

using System;
using System.Collections.Generic;

namespace Model.Util
{
    public class Country
    {
        private String name;

        private List<City> city;

        /// <summary>
        /// Property for collection of City
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<City> City
        {
            get
            {
                if (city == null)
                    city = new List<City>();
                return city;
            }
            set
            {
                RemoveAllCity();
                if (value != null)
                {
                    foreach (City oCity in value)
                        AddCity(oCity);
                }
            }
        }

        public string Name { get => name; }

        public Country(string name)
        {
            this.name = name;
        }



        /// <summary>
        /// Add a new City in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddCity(City newCity)
        {
            if (newCity == null)
                return;
            if (this.city == null)
                this.city = new List<City>();
            if (!this.city.Contains(newCity))
                this.city.Add(newCity);
        }

        /// <summary>
        /// Remove an existing City from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveCity(City oldCity)
        {
            if (oldCity == null)
                return;
            if (this.city != null)
                if (this.city.Contains(oldCity))
                    this.city.Remove(oldCity);
        }

        /// <summary>
        /// Remove all instances of City from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllCity()
        {
            if (city != null)
                city.Clear();
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            Country other = obj as Country;
            if(other == null)
            {
                return false;
            }
            return this.Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}