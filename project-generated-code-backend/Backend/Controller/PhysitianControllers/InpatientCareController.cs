// File:    InpatientCareController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCareController

using Backend.Dto;
using Backend.Service.PatientCareService;
using Model.Accounts;
using System;
using System.Collections.Generic;

namespace Backend.Controller.PhysitianControllers
{
    public class InpatientCareController
    {
        private Physitian loggedPhysitian;
        private InpatientCareService inpatientCareService;

        public InpatientCareController(Physitian loggedPhysitian)
        {
            this.loggedPhysitian = loggedPhysitian;
            this.inpatientCareService = new InpatientCareService();
        }

        public void StartInpatientCare(BedReservationDTO bedReservationDTO)
        {
            throw new NotImplementedException();
        }

        public void DischargeParient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public BedReservationDTO getActiveInpatientCare(Patient patient)
        {
            //TODO: Get active bed reservation
            return null;
        }
        public List<BedReservationDTO> getPreviousInpatientCares(Patient patient)
        {
            //TODO: Get inpatient cares
            return new List<BedReservationDTO>();
        }

    }
}