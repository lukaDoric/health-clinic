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
        public PhysitianRepository physitianRepository;
        public ProcedureTypeRepository procedureTypeRepository;

        public HospitalService()
        {
            patientRepository = new PatientFileSystem();
            countryRepository = new CountryFileSystem();
            physitianRepository = new PhysitianFileSystem();
            procedureTypeRepository = new ProcedureTypeFileSystem();
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

        internal List<ProcedureType> GetAllProcedureTypes()
        {
            return procedureTypeRepository.GetAll();
        }

        internal List<TimeInterval> GetAllVacations(Physitian physitianDTO)
        {
            return physitianRepository.GetById(physitianDTO.SerialNumber).VacationTime;
        }

        internal void AddVacation(TimeInterval timeInterval, Physitian physitianDTO)
        {
            physitianDTO.AddVacationTime(timeInterval);
            physitianRepository.Update(physitianDTO);
        }

        internal void RemoveVacation(TimeInterval timeInterval, Physitian physitianDTO)
        {
            physitianDTO.RemoveVacationTime(timeInterval);
            physitianRepository.Update(physitianDTO);
        }

        internal void DeletePhysician(Physitian physitian)
        {
            physitianRepository.Delete(physitian.SerialNumber);
        }

        public List<Physitian> GetAllPhysitians()
        {
            return physitianRepository.GetAll();
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