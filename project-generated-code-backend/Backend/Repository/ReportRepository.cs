// File:    ReportRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface ReportRepository

using Model.MedicalExam;
using System;

namespace Backend.Repository
{
   public interface ReportRepository : GenericRepository<Report>
   {
   }
}