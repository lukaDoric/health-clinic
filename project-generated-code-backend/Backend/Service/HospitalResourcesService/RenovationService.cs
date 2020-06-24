// File:    RenovationService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RenovationService

using Backend.Dto;
using Backend.Repository;
using HealthClinic.Backend.Model.Hospital;
using Model.Hospital;
using System;
using System.Collections.Generic;

namespace Backend.Service.HospitalResourcesService
{
    public class RenovationService
    {
        public Backend.Dto.RenovationDTO GetById(String id)
        {
            throw new NotImplementedException();
        }

        public List<RenovationDTO> GetAll()
        {
            List<RenovationDTO> renovations = new List<RenovationDTO>();
            List<Room> rooms  = roomRepository.GetAll();
            foreach(Room room in rooms)
            {
                renovations.AddRange(room.RenovationTime);
            }
            return renovations;
        }

        public void EditRenovation(Backend.Dto.RenovationDTO renovation)
        {
            throw new NotImplementedException();
        }

        public void DeleteRenovation(Backend.Dto.RenovationDTO renovation)
        {
            throw new NotImplementedException();
        }

        public void NewRenovation(Backend.Dto.RenovationDTO renovation)
        {
            throw new NotImplementedException();
        }

        public Backend.Repository.RoomRepository roomRepository;

        public RenovationService()
        {
            roomRepository = new RoomFileSystem();
        }
    }
}