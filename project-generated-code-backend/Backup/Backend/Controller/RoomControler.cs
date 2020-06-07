// File:    RoomControler.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RoomControler

using System;

namespace Backend.Controller
{
   public class RoomControler
   {
      public Backend.Model.Hospital.Room GetById(String id)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void EditRoom(Backend.Model.Hospital.Room room)
      {
         throw new NotImplementedException();
      }
      
      public void NewRoom(Backend.Model.Hospital.Room room)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteRoom(Backend.Model.Hospital.Room room)
      {
         throw new NotImplementedException();
      }
      
      public void AddEquipment(Backend.Model.Hospital.Equipment equipment, Backend.Model.Hospital.Room room)
      {
         throw new NotImplementedException();
      }
      
      public void RemoveEquipmentById(String id, Backend.Model.Hospital.Room room)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Service.RoomService roomService;
   
   }
}