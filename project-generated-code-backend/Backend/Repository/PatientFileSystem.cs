// File:    PatientFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientFileSystem

using Model.Accounts;
using System;
using System.Collections.Generic;

namespace Backend.Repository
{
    public class PatientFileSystem : GenericFileRepository<Patient>, PatientRepository
    {
        public List<Patient> GetPatientsByPhysitian(Physitian physitian)
        {
            throw new NotImplementedException();
        }
    }
}