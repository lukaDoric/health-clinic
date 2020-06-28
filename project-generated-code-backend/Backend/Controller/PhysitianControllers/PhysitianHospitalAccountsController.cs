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
using health_clinic_class_diagram.Backend.Service.HospitalAccountsService;
using Backend.Service.SchedulingService;

namespace Backend.Controller.PhysitianControllers
{
    public class PhysitianHospitalAccountsController
    {
        private Physitian loggedPhysitian;
        private HospitalService hospitalService;
        private ReportService reportService;
        private PatientAccountsService patientAccountsService;
        private PhysitianScheduleService physitianScheduleService;

        public PhysitianHospitalAccountsController(Physitian loggedPhysitian)
        {
            this.loggedPhysitian = loggedPhysitian;
            this.hospitalService = new HospitalService();
            this.reportService = new ReportService();
            this.patientAccountsService = new PatientAccountsService();
            this.physitianScheduleService = new PhysitianScheduleService(loggedPhysitian);
        }

        public List<Patient> GetPatientsByPhysitian()
        {
            return patientAccountsService.getPatientsForPhysitian(loggedPhysitian);
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
            //TODO:
            return true;
        }

        public List<Report> getAllReportsForPatient(Patient patient)
        {
            return reportService.GetReportsByPatient(patient);
        }
        public Report getLastReportForPatient(Patient patient)
        {
            return reportService.GetLastReportByPatient(patient);
        }

        internal Appointment getTodaysAppointmentForPatient(Patient patient)
        {
            return physitianScheduleService.GetTodaysAppointmentForPatient(patient);
        }
    }
}