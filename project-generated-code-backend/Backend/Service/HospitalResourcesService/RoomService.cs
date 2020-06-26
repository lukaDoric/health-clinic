// File:    RoomService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RoomService

using Backend.Repository;
using Model.Hospital;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return  roomRepository.GetAll();
        }

        public void EditRoom(Room room)
        {
            roomRepository.Update(room);
        }

        public void NewRoom(Room room)
        {
            roomRepository.Save(room);
        }

        public void DeleteRoom(Room room)
        {
            roomRepository.Delete(room.SerialNumber);
        }

        public void AddEquipment(Equipment equipment, Room room)
        {
            room.AddEquipment(equipment);
            roomRepository.Update(room);
        }

        public void RemoveEquipmentById(String id, Room room)
        {
           
            foreach(Equipment e in room.Equipment.ToList())
            {
                if (e.SerialNumber.Equals(id))
                {
                    room.RemoveEquipment(e);
                }
            }
            roomRepository.Update(room);
        }

        public List<Equipment> GetAllEquipment(Room room)
        {
            return roomRepository.GetById(room.SerialNumber).Equipment;
        }


        public Backend.Repository.RoomRepository roomRepository;

        public RoomService()
        {
            roomRepository = new RoomFileSystem();
        }
    }
}