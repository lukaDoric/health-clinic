// File:    InpatientCare.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCare

using Backend.Model.Accounts;
using System;

namespace Backend.Model.MedicalExam
{
    public class InpatientCare
    {
        private DateTime dateOfAdmition;
        private DateTime dateOfDischarge;
        private String reason;

        private Physitian physitian;
        private Patient patient;

        public InpatientCare(DateTime dateOfAdmition, DateTime dateOfDischarge, string reason, Physitian physitian, Patient patient)
        {
            this.dateOfAdmition = dateOfAdmition;
            this.dateOfDischarge = dateOfDischarge;
            this.reason = reason;
            this.physitian = physitian;
            this.patient = patient;
        }

        public DateTime DateOfAdmition { get => dateOfAdmition; }
        public DateTime DateOfDischarge { get => dateOfDischarge; }
        public string Reason { get => reason; }
        public Physitian Physitian { get => physitian; }
        public Patient Patient { get => patient; }
    }
}