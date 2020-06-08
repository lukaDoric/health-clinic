// File:    SpecialistReferral.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SpecialistReferral

using Backend.Model.Accounts;
using System;

namespace Backend.Model.MedicalExam
{
    public class SpecialistReferral : AdditionalDocument
    {
        private Specialization specialization;
        private Physitian physitian;

        public SpecialistReferral(DateTime date, string notes, Report report, Specialization specialization, Physitian physitian) : base(date, notes, report)
        {
            this.specialization = specialization;
            this.physitian = physitian;
        }

        public Specialization Specialization { get => specialization; }
        public Physitian Physitian { get => physitian; }

        public override string ToString()
        {
            return Specialization.ToString() + " " + Physitian.ToString() + " " + Date.ToString("dd.MM.yyyy");
        }
    }
}