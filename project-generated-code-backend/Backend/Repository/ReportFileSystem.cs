// File:    ReportFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ReportFileSystem

using Model.MedicalExam;
using System;

namespace Backend.Repository
{
    public class ReportFileSystem : GenericFileRepository<Report>, ReportRepository
    {
        public override Report Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}