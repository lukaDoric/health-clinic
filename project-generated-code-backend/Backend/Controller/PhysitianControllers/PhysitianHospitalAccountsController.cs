// File:    PhysitianHospitalController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianHospitalController

using Model.Accounts;
using Backend.Service.HospitalAccountsService;
using System;
using System.Collections.Generic;
using Backend.Service.PatientCareService;
using Model.MedicalExam;
using Model.Schedule;

namespace Backend.Controller.PhysitianControllers
{
    public class PhysitianHospitalAccountsController
    {
        private Physitian loggedPhysitian;
        private HospitalService hospitalService;
        private ReportService reportService;

        public PhysitianHospitalAccountsController(Physitian loggedPhysitian)
        {
            this.loggedPhysitian = loggedPhysitian;
            this.hospitalService = new HospitalService();
            this.reportService = new ReportService();
        }

        public List<Patient> GetPatientsByPhysitian(Patient physitian)
        {
            throw new NotImplementedException();
        }

        public Appointment GetNextAppointmentForPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Appointment GetPreviousAppointmentForPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
        public bool IsPatientScheduledToday(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<Report> getAllReportsForPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
        public Report getLastReportForPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}