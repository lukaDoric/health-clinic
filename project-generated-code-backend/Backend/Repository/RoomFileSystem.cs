// File:    RoomFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RoomFileSystem

using Model.Hospital;
using Model.MedicalExam;
using Model.Schedule;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Backend.Repository
{
    public class RoomFileSystem : GenericFileSystem<Room>, RoomRepository
    {
        public RoomFileSystem()
        {
            path = @"./../../data/rooms.txt";
        }

        public List<Room> GetRoomsByProcedureType(ProcedureType procedureType)
        {
            List<Room> rooms = new List<Room>();
            foreach (Room room in GetAll())
            {
                if (room.ContainsAllEquipment(procedureType.RequiredEquipment))
                {
                    rooms.Add(room);
                }
            }
            return rooms;
        }

        public override Room Instantiate(string objectStringFormat)
        {
            return JsonConvert.DeserializeObject<Room>(objectStringFormat);
        }

    }
}