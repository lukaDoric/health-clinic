// File:    RoomControler.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RoomControler

using Model.Hospital;
using Backend.Service.HospitalResourcesService;
using System;
using System.Collections.Generic;

namespace Backend.Controller.SuperintendentControllers
{
   public class RoomController
   {
      public Room GetById(String id)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetAll()
      {
            return roomService.GetAll();
      }
      
      public void EditRoom(Room room)
      {
            roomService.EditRoom(room);
      }
      
      public void NewRoom(Room room)
      {
            roomService.NewRoom(room);
      }
      
      public void DeleteRoom(Room room)
      {
            roomService.DeleteRoom(room);
      }
      
      public void AddEquipment(Equipment equipment, Room room)
      {
            roomService.AddEquipment(equipment, room);
      }
      
      public void RemoveEquipmentById(String id, Room room)
      {
            roomService.RemoveEquipmentById(id, room);
      }

      public List<Equipment> GetAllEquipment(Room room)
      {
            return roomService.GetAllEquipment(room);
      }



        public RoomService roomService;

        public RoomController()
        {
            roomService = new RoomService();
        }
    }
}