// File:    InpatientCareRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface InpatientCareRepository

using Backend.Model.MedicalExam;
using System;

namespace Backend.Repository
{
   public interface InpatientCareRepository : GenericRepository<InpatientCare>
   {
      void StartInpatientCare(Backend.Model.Hospital.BedReservation bedReservation);
      
      void EndInpatientCare(DateTime dateOfDischarge);
   
   }
}