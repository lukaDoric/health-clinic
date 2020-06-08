// File:    Country.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Country

using System;

namespace Backend.Model.Util
{
   public class Country
   {
      private String name;
      
      private System.Collections.Generic.List<City> city;
      
      /// <summary>
      /// Property for collection of City
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<City> City
      {
         get
         {
            if (city == null)
               city = new System.Collections.Generic.List<City>();
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

        public string Name { get => name;}

        /// <summary>
        /// Add a new City in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddCity(City newCity)
      {
         if (newCity == null)
            return;
         if (this.city == null)
            this.city = new System.Collections.Generic.List<City>();
         if (!this.city.Contains(newCity))
         {
            this.city.Add(newCity);
            newCity.Country = this;
         }
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
            {
               this.city.Remove(oldCity);
               oldCity.Country = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of City from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllCity()
      {
         if (city != null)
         {
            System.Collections.ArrayList tmpCity = new System.Collections.ArrayList();
            foreach (City oldCity in city)
               tmpCity.Add(oldCity);
            city.Clear();
            foreach (City oldCity in tmpCity)
               oldCity.Country = null;
            tmpCity.Clear();
         }
      }
   
   }
}