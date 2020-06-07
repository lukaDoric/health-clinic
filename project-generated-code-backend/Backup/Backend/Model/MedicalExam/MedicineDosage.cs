// File:    MedicineDosage.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class MedicineDosage

using System;

namespace Backend.Model.MedicalExam
{
   public class MedicineDosage
   {
      private double ammount;
      private int frequency;
      private String note;
      
      private Backend.Model.Hospital.Medicine medicine;
      
      /// <summary>
      /// Property for Backend.Model.Hospital.Medicine
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Backend.Model.Hospital.Medicine Medicine
      {
         get
         {
            return medicine;
         }
         set
         {
            if (this.medicine == null || !this.medicine.Equals(value))
            {
               if (this.medicine != null)
               {
                  Backend.Model.Hospital.Medicine oldMedicine = this.medicine;
                  this.medicine = null;
                  oldMedicine.RemoveMedicineDosage(this);
               }
               if (value != null)
               {
                  this.medicine = value;
                  this.medicine.AddMedicineDosage(this);
               }
            }
         }
      }
   
   }
}