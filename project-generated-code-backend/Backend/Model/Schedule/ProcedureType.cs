// File:    ProcedureType.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ProcedureType

using Backend.Model.Hospital;
using System;

namespace Backend.Model.Schedule
{
   public class ProcedureType
   {
      private String name;
      
      private Backend.Model.Accounts.Specialization specialization;
      private System.Collections.Generic.List<Equipment> requiredEquipment;
      
      /// <summary>
      /// Property for collection of Backend.Model.Hospital.Equipment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Equipment> RequiredEquipment
      {
         get
         {
            if (requiredEquipment == null)
               requiredEquipment = new System.Collections.Generic.List<Equipment>();
            return requiredEquipment;
         }
         set
         {
            RemoveAllRequiredEquipment();
            if (value != null)
            {
               foreach (Backend.Model.Hospital.Equipment oEquipment in value)
                  AddRequiredEquipment(oEquipment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Backend.Model.Hospital.Equipment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRequiredEquipment(Backend.Model.Hospital.Equipment newEquipment)
      {
         if (newEquipment == null)
            return;
         if (this.requiredEquipment == null)
            this.requiredEquipment = new System.Collections.Generic.List<Equipment>();
         if (!this.requiredEquipment.Contains(newEquipment))
            this.requiredEquipment.Add(newEquipment);
      }
      
      /// <summary>
      /// Remove an existing Backend.Model.Hospital.Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRequiredEquipment(Backend.Model.Hospital.Equipment oldEquipment)
      {
         if (oldEquipment == null)
            return;
         if (this.requiredEquipment != null)
            if (this.requiredEquipment.Contains(oldEquipment))
               this.requiredEquipment.Remove(oldEquipment);
      }
      
      /// <summary>
      /// Remove all instances of Backend.Model.Hospital.Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRequiredEquipment()
      {
         if (requiredEquipment != null)
            requiredEquipment.Clear();
      }
   
   }
}