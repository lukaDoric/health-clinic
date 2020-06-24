// File:    PatientRegistrationService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientRegistrationService

using Backend.Dto;
using Backend.Repository;
using Model.Accounts;
using System;

namespace Backend.Service.HospitalAccountsService
{
    public class PatientRegistrationService
    {
        public PatientRepository patientRepository;

        public PatientRegistrationService()
        {
            patientRepository = new PatientFileSystem();
        }

        private bool IsJMBGValid(String jmbg)
        {
            throw new NotImplementedException();
        }

        private bool IsGuestAccount(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void RegisterPatient(PatientDTO patientDTO)
        {
            throw new NotImplementedException();
        }

        public void DeletePatientAccount(Patient patient)
        {
            patientRepository.Delete(patient.SerialNumber);
        }

    }
}