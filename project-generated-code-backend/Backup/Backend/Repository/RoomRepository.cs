// File:    RoomRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface RoomRepository

using System;

namespace Backend.Repository
{
   public interface RoomRepository : GenericRepository<T>
   {
      List<Room> GetRoomsByEquipment(List<Equipment> equipment);
   
   }
}