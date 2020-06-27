// File:    SecretaryHospitalController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SecretaryHospitalController

using Model.Accounts;
using Backend.Service.HospitalAccountsService;
using System;
using System.Collections.Generic;
using Model.Util;
using Backend.Service.HospitalResourcesService;
using Model.Hospital;

namespace Backend.Controller.SecretaryControllers
{
    public class SecretaryHospitalController
    {
        public HospitalService hospitalService;
        public RoomService roomService;

        public SecretaryHospitalController()
        {
            hospitalService = new HospitalService();
            roomService = new RoomService();
        }

        public List<Patient> GetAllPatients()
        {
            return hospitalService.GetAllPatients();
        }

        public List<Physitian> GetAllPhysitians()
        {
            return hospitalService.GetAllPhysitians();
        }

        public List<Room> GetAllRooms()
        {
            return roomService.GetAll();
        }

        internal List<Country> GetAllCountries()
        {
            return hospitalService.getAllCountries();
        }
    }
}