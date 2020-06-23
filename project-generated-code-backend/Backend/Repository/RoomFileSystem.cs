// File:    RoomFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RoomFileSystem

using Model.Hospital;
using Model.MedicalExam;
using System;
using System.Collections.Generic;

namespace Backend.Repository
{
    public class RoomFileSystem : GenericFileRepository<Room>, RoomRepository
    {
        public List<Room> GetRoomsByEquipment(List<Equipment> equipment)
        {
            throw new NotImplementedException();
        }

        public override Room Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }

    }
}