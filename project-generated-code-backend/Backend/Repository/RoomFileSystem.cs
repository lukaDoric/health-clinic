// File:    RoomFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RoomFileSystem

using Model.Hospital;
using Model.MedicalExam;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Backend.Repository
{
    public class RoomFileSystem : GenericFileSystem<Room>, RoomRepository
    {
        public RoomFileSystem()
        {
            path = @"./../../../HealthClinic/data/rooms.txt";
        }
        public List<Room> GetRoomsByEquipment(List<Equipment> equipment)
        {
            throw new NotImplementedException();
        }

        public override Room Instantiate(string objectStringFormat)
        {
            return JsonConvert.DeserializeObject<Room>(objectStringFormat);
        }

    }
}