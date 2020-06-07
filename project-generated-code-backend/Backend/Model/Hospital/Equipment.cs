// File:    Equipment.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Equipment

using System;

namespace Backend.Model.Hospital
{
   public class Equipment
   {
      private String name;
      private String id;
      
      protected Room room;
      
      /// <summary>
      /// Property for Room
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Room Room
      {
         get
         {
            return room;
         }
         set
         {
            if (this.room == null || !this.room.Equals(value))
            {
               if (this.room != null)
               {
                  Room oldRoom = this.room;
                  this.room = null;
                  oldRoom.RemoveEquipment(this);
               }
               if (value != null)
               {
                  this.room = value;
                  this.room.AddEquipment(this);
               }
            }
         }
      }
   
   }
}