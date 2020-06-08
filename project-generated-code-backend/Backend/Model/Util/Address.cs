// File:    Adress.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Adress

using System;

namespace Backend.Model.Util
{
    public class Address
    {
        private String street;
        private int number;

        private City city;

        /// <summary>
        /// Property for City
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public City City
        {
            get
            {
                return city;
            }
            set
            {
                if (this.city == null || !this.city.Equals(value))
                {
                    if (this.city != null)
                    {
                        City oldCity = this.city;
                        this.city = null;
                        oldCity.RemoveAdress(this);
                    }
                    if (value != null)
                    {
                        this.city = value;
                        this.city.AddAdress(this);
                    }
                }
            }
        }

        public string Street { get => street; }
        public int Number { get => number; }

        public override string ToString()
        {
            return Street + " " + Number.ToString() + ", " + City.Name;
        }
    }
}