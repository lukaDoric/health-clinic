// File:    City.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class City

using System;

namespace Backend.Model.Util
{
   public class City
   {
      private String name;
      private String postalCode;
      
      private System.Collections.Generic.List<Adress> adress;
      
      /// <summary>
      /// Property for collection of Adress
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Adress> Adress
      {
         get
         {
            if (adress == null)
               adress = new System.Collections.Generic.List<Adress>();
            return adress;
         }
         set
         {
            RemoveAllAdress();
            if (value != null)
            {
               foreach (Adress oAdress in value)
                  AddAdress(oAdress);
            }
         }
      }
      
      /// <summary>
      /// Add a new Adress in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAdress(Adress newAdress)
      {
         if (newAdress == null)
            return;
         if (this.adress == null)
            this.adress = new System.Collections.Generic.List<Adress>();
         if (!this.adress.Contains(newAdress))
         {
            this.adress.Add(newAdress);
            newAdress.City = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Adress from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAdress(Adress oldAdress)
      {
         if (oldAdress == null)
            return;
         if (this.adress != null)
            if (this.adress.Contains(oldAdress))
            {
               this.adress.Remove(oldAdress);
               oldAdress.City = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Adress from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAdress()
      {
         if (adress != null)
         {
            System.Collections.ArrayList tmpAdress = new System.Collections.ArrayList();
            foreach (Adress oldAdress in adress)
               tmpAdress.Add(oldAdress);
            adress.Clear();
            foreach (Adress oldAdress in tmpAdress)
               oldAdress.City = null;
            tmpAdress.Clear();
         }
      }
      private Country country;
      
      /// <summary>
      /// Property for Country
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Country Country
      {
         get
         {
            return country;
         }
         set
         {
            if (this.country == null || !this.country.Equals(value))
            {
               if (this.country != null)
               {
                  Country oldCountry = this.country;
                  this.country = null;
                  oldCountry.RemoveCity(this);
               }
               if (value != null)
               {
                  this.country = value;
                  this.country.AddCity(this);
               }
            }
         }
      }
   
   }
}