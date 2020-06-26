// File:    ReportFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ReportFileSystem

using Model.MedicalExam;
using Newtonsoft.Json;
using System;

namespace Backend.Repository
{
    public class ReportFileSystem : GenericFileSystem<Report>, ReportRepository
    {
        public ReportFileSystem()
        {
            path = @"./../../../../project-generated-code-backend/data/reports.txt";
        }
        public override Report Instantiate(string objectStringFormat)
        {
            return JsonConvert.DeserializeObject<Report>(objectStringFormat);
        }
    }
}