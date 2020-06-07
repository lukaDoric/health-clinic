// File:    ReportFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ReportFileSystem

using Backend.Model.MedicalExam;
using System;

namespace Backend.Repository
{
   public class ReportFileSystem : GenericFileRepository<Report>, ReportRepository
   {
   }
}