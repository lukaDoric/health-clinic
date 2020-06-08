// File:    PhysitianHospitalController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianHospitalController

using Backend.Model.Accounts;
using Backend.Service.HospitalAccountsService;
using System;
using System.Collections.Generic;

namespace Backend.Controller.PhysitianControllers
{
    public class PhysitianHospitalController
    {
        private Backend.Model.Accounts.Physitian loggedPhysitian;

        public HospitalService hospitalService;

        public List<Patient> GetPatientsByPhysitian(Backend.Model.Accounts.Patient physitian)
        {
            throw new NotImplementedException();
        }

        public Patient getPatient(String id)
        {
            throw new NotImplementedException();
        }
    }
}