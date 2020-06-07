// File:    Room.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Room

using Backend.Model.Schedule;
using System;

namespace Backend.Model.Hospital
{
   public class Room
   {
      private int id;
      
      private RoomType roomType;
      private Backend.Model.Util.TimeInterval[] renovationTime;
      private System.Collections.Generic.List<Equipment> equipment;
      
      /// <summary>
      /// Property for collection of Equipment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Equipment> Equipment
      {
         get
         {
            if (equipment == null)
               equipment = new System.Collections.Generic.List<Equipment>();
            return equipment;
         }
         set
         {
            RemoveAllEquipment();
            if (value != null)
            {
               foreach (Equipment oEquipment in value)
                  AddEquipment(oEquipment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Equipment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddEquipment(Equipment newEquipment)
      {
         if (newEquipment == null)
            return;
         if (this.equipment == null)
            this.equipment = new System.Collections.Generic.List<Equipment>();
         if (!this.equipment.Contains(newEquipment))
         {
            this.equipment.Add(newEquipment);
            newEquipment.Room = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveEquipment(Equipment oldEquipment)
      {
         if (oldEquipment == null)
            return;
         if (this.equipment != null)
            if (this.equipment.Contains(oldEquipment))
            {
               this.equipment.Remove(oldEquipment);
               oldEquipment.Room = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllEquipment()
      {
         if (equipment != null)
         {
            System.Collections.ArrayList tmpEquipment = new System.Collections.ArrayList();
            foreach (Equipment oldEquipment in equipment)
               tmpEquipment.Add(oldEquipment);
            equipment.Clear();
            foreach (Equipment oldEquipment in tmpEquipment)
               oldEquipment.Room = null;
            tmpEquipment.Clear();
         }
      }
      private Appointment[] appointment;
   
   }
}