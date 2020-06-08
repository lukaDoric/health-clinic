// File:    BedReservation.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class BedReservation

using Backend.Model.Accounts;
using Backend.Model.Util;
using System;

namespace Backend.Model.Hospital
{
   public class BedReservation
   {
      private Backend.Model.Util.TimeInterval timeInterval;
      private Backend.Model.Accounts.Patient patient;
      private Bed bed;
      
      /// <summary>
      /// Property for Bed
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Bed Bed
      {
         get
         {
            return bed;
         }
         set
         {
            if (this.bed == null || !this.bed.Equals(value))
            {
               if (this.bed != null)
               {
                  Bed oldBed = this.bed;
                  this.bed = null;
                  oldBed.RemoveBedReservation(this);
               }
               if (value != null)
               {
                  this.bed = value;
                  this.bed.AddBedReservation(this);
               }
            }
         }
      }

        public TimeInterval TimeInterval
        {
            get
            {
                return timeInterval;
            }
            set
            {
                timeInterval = value;
            }
        }
        public Patient Patient { get => patient; }
    }
}