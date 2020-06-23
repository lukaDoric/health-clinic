// File:    InpatientCareFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCareFileSystem

using Model.Hospital;
using Model.MedicalExam;
using System;

namespace Backend.Repository
{
    public class InpatientCareFileSystem : GenericFileRepository<InpatientCare>, InpatientCareRepository
    {
        public void EndInpatientCare(DateTime dateOfDischarge)
        {
            throw new NotImplementedException();
        }

        public override InpatientCare Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }

        public void StartInpatientCare(BedReservation bedReservation)
        {
            throw new NotImplementedException();
        }
    }
}