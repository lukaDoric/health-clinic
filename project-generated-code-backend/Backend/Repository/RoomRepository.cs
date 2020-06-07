// File:    RoomRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface RoomRepository

using Backend.Model.Hospital;
using System;
using System.Collections.Generic;

namespace Backend.Repository
{
   public interface RoomRepository : GenericRepository<Room>
   {
      List<Room> GetRoomsByEquipment(List<Equipment> equipment);
   
   }
}