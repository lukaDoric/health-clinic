// File:    RoomService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RoomService

using Model.Hospital;
using System;
using System.Collections.Generic;

namespace Backend.Service.HospitalResourcesService
{
    public class RoomService
    {
        public Room GetById(String id)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public void EditRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void NewRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void AddEquipment(Equipment equipment, Room room)
        {
            throw new NotImplementedException();
        }

        public void RemoveEquipmentById(String id, Room room)
        {
            throw new NotImplementedException();
        }

        public Backend.Repository.RoomRepository roomRepository;

    }
}