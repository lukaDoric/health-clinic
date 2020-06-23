// File:    ApprovedMedicineFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ApprovedMedicineFileSystem

using Model.Hospital;
using System;

namespace Backend.Repository
{
    public class ApprovedMedicineFileSystem : GenericFileRepository<Medicine>, ApprovedMedicineRepository
    {
        public override Medicine Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}