// File:    SuperIntendentHospitalController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SuperIntendentHospitalController

using Backend.Service.HospitalAccountsService;
using Model.Accounts;
using Model.Util;
using System;
using System.Collections.Generic;

namespace Backend.Controller.SuperintendentControllers
{
   public class SuperIntendentHospitalController
   {
        public HospitalService hospitalService;

        public SuperIntendentHospitalController()
        {
            hospitalService = new HospitalService();
        }

        public List<Physitian> GetAllPhysitians()
        {
            return hospitalService.GetAllPhysitians();
        }
        public void NewPhysician(Physitian physitian)
        {
            hospitalService.NewPhysician(physitian);
        }

        public void EditPhysitian(Physitian physitian)
        {
            hospitalService.EditPhysician(physitian);
        }

        public void DeletePhysitian(Physitian physitian)
        {
            hospitalService.DeletePhysician(physitian);
        }

        internal List<TimeInterval> GetAllVacations(Physitian physitianDTO)
        {
            return hospitalService.GetAllVacations(physitianDTO);
        }

        internal void AddVacation(TimeInterval timeInterval, Physitian physitianDTO)
        {
            hospitalService.AddVacation(timeInterval, physitianDTO);
        }

        internal void RemoveVacation(TimeInterval timeInterval, Physitian physitianDTO)
        {
            hospitalService.RemoveVacation(timeInterval, physitianDTO);
        }

    }
}