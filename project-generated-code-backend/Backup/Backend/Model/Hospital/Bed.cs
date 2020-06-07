// File:    Bed.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Bed

using System;

namespace Backend.Model.Hospital
{
   public class Bed : Equipment
   {
      private System.Collections.Generic.List<BedReservation> bedReservation;
      
      /// <summary>
      /// Property for collection of BedReservation
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<BedReservation> BedReservation
      {
         get
         {
            if (bedReservation == null)
               bedReservation = new System.Collections.Generic.List<BedReservation>();
            return bedReservation;
         }
         set
         {
            RemoveAllBedReservation();
            if (value != null)
            {
               foreach (BedReservation oBedReservation in value)
                  AddBedReservation(oBedReservation);
            }
         }
      }
      
      /// <summary>
      /// Add a new BedReservation in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddBedReservation(BedReservation newBedReservation)
      {
         if (newBedReservation == null)
            return;
         if (this.bedReservation == null)
            this.bedReservation = new System.Collections.Generic.List<BedReservation>();
         if (!this.bedReservation.Contains(newBedReservation))
         {
            this.bedReservation.Add(newBedReservation);
            newBedReservation.Bed = this;
         }
      }
      
      /// <summary>
      /// Remove an existing BedReservation from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveBedReservation(BedReservation oldBedReservation)
      {
         if (oldBedReservation == null)
            return;
         if (this.bedReservation != null)
            if (this.bedReservation.Contains(oldBedReservation))
            {
               this.bedReservation.Remove(oldBedReservation);
               oldBedReservation.Bed = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of BedReservation from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllBedReservation()
      {
         if (bedReservation != null)
         {
            System.Collections.ArrayList tmpBedReservation = new System.Collections.ArrayList();
            foreach (BedReservation oldBedReservation in bedReservation)
               tmpBedReservation.Add(oldBedReservation);
            bedReservation.Clear();
            foreach (BedReservation oldBedReservation in tmpBedReservation)
               oldBedReservation.Bed = null;
            tmpBedReservation.Clear();
         }
      }
   
   }
}