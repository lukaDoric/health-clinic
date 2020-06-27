// File:    HospitalService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class HospitalService

using Backend.Repository;
using HCI_SIMS_PROJEKAT.Backend.Repository;
using Model.Accounts;
using Model.Schedule;
using Model.Util;
using System;
using System.Collections.Generic;

namespace Backend.Service.HospitalAccountsService
{
    //TODO: REFAKTORISATI samo geteri za country, procedure type, room type... (stvari koje idu u CB)
    // Dodati PhysitianAccountsService i SecretaryAccountsService 
    public class HospitalService
    {
        public PatientRepository patientRepository;
        public CountryRepository countryRepository;
        public ProcedureTypeRepository procedureTypeRepository;

        public HospitalService()
        {
            patientRepository = new PatientFileSystem();
            countryRepository = new CountryFileSystem();
            procedureTypeRepository = new ProcedureTypeFileSystem();
        }

        public List<Patient> GetAllPatients()
        {
            return patientRepository.GetAll();
        }

        internal List<ProcedureType> GetAllProcedureTypes()
        {
            return procedureTypeRepository.GetAll();
        }

        public List<Secretary> GetSecretaries()
        {
            throw new NotImplementedException();
        }

        internal List<Country> getAllCountries()
        {
            return countryRepository.GetAll();
        }

        public Patient getPatient(String id)
        {
            throw new NotImplementedException();
        }

        public Physitian getPhysitian(String id)
        {
            throw new NotImplementedException();
        }

    }
}