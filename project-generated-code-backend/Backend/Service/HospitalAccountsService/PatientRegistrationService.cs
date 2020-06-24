// File:    PatientRegistrationService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientRegistrationService

using Backend.Dto;
using Backend.Repository;
using Model.Accounts;
using System;
using System.Collections.Generic;

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
            List<Patient> patients = patientRepository.GetAll();
            foreach (Patient p in patients)
            {
                if (p.Id == jmbg)
                {
                    Console.WriteLine("JMBG");
                    return false;
                }
            }
            return true;
        }

        public bool IsGuest(String jmbg)
        {
            List<Patient> patients = patientRepository.GetAll();
            foreach (Patient p in patients)
            {
                if (p.Id == jmbg)
                {
                    if (p.Guest)
                    {
                        Console.WriteLine("GUEST");
                        return true;
                    }
                }
            }
            return false;
        }

        public void RegisterPatient(PatientDTO patientDTO)
        {
            if (!IsJMBGValid(patientDTO.Id) && IsGuest(patientDTO.Id))
            {
                patientRepository.Update(new Patient(patientDTO));
            }
            else if (IsJMBGValid(patientDTO.Id))
            {
                patientRepository.Save(new Patient(patientDTO));
            }
            else
            {
                return;
            }
        }

        public void DeletePatientAccount(Patient patient)
        {
            patientRepository.Delete(patient.SerialNumber);
        }

    }
}