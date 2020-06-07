// File:    ApprovedMedicineFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ApprovedMedicineFileSystem

using Backend.Model.Hospital;
using System;

namespace Backend.Repository
{
   public class ApprovedMedicineFileSystem : GenericFileRepository<Medicine>, ApprovedMedicineRepository
   {
   }
}