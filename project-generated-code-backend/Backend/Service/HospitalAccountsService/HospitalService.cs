// File:    HospitalService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class HospitalService

using Backend.Repository;
using HCI_SIMS_PROJEKAT.Backend.Repository;
using Model.Accounts;
using Model.Util;
using System;
using System.Collections.Generic;

namespace Backend.Service.HospitalAccountsService
{
    public class HospitalService
    {
        public PatientRepository patientRepository;
        public CountryRepository countryRepository;
        public PhysitianRepository physitianRepository;

        public HospitalService()
        {
            patientRepository = new PatientFileSystem();
            countryRepository = new CountryFileSystem();
            physitianRepository = new PhysitianFileSystem();
        }

        public List<Patient> GetAllPatients()
        {
            return patientRepository.GetAll();
        }

        internal void NewPhysician(Physitian physitian)
        {
            physitianRepository.Save(physitian);
        }

        internal void EditPhysician(Physitian physitian)
        {
            physitianRepository.Update(physitian);
        }

        internal void DeletePhysicianById(string id)
        {
            physitianRepository.Delete(id);
        }

        internal void DeletePhysician(Physitian physitian)
        {
            physitianRepository.Delete(physitian.SerialNumber);
        }

        public List<Physitian> GetAllPhysitians()
        {
            return physitianRepository.GetAll();
        }



        public List<Patient> GetPatientsByPhysitian(Patient physitian)
        {
            throw new NotImplementedException();
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