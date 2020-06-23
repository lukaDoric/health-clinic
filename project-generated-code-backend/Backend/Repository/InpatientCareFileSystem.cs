// File:    InpatientCareFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCareFileSystem

using Model.Hospital;
using Model.MedicalExam;
using Newtonsoft.Json;
using System;

namespace Backend.Repository
{
    public class InpatientCareFileSystem : GenericFileSystem<InpatientCare>, InpatientCareRepository
    {
        public InpatientCareFileSystem()
        {
            path = @"./../../../../project-generated-code-backend/data/inpatient_care.txt";
        }
        public void EndInpatientCare(DateTime dateOfDischarge)
        {
            throw new NotImplementedException();
        }

        public override InpatientCare Instantiate(string objectStringFormat)
        {
           return JsonConvert.DeserializeObject<InpatientCare>(objectStringFormat);
        }

        public void StartInpatientCare(BedReservation bedReservation)
        {
            throw new NotImplementedException();
        }
    }
}