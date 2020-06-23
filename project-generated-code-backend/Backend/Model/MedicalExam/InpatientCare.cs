// File:    InpatientCare.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class InpatientCare

using Model.Accounts;
using System;

namespace Model.MedicalExam
{
    public class InpatientCare
    {
        private DateTime dateOfAdmition;
        private DateTime dateOfDischarge;
        private String reason;

        private Physitian physitian;
        private Patient patient;

        public DateTime DateOfAdmition { get => dateOfAdmition; }
        public DateTime DateOfDischarge { get => dateOfDischarge; }
        public string Reason { get => reason; }
        public Physitian Physitian { get => physitian; }
        public Patient Patient { get => patient; }

        public InpatientCare(DateTime dateOfAdmition, DateTime dateOfDischarge, string reason, Physitian physitian, Patient patient)
        {
            this.dateOfAdmition = dateOfAdmition;
            this.dateOfDischarge = dateOfDischarge;
            this.reason = reason;
            this.physitian = physitian;
            this.patient = patient;
        }

        public override bool Equals(object obj)
        {
            InpatientCare other = obj as InpatientCare;
            if(other == null)
            {
                return false;
            }
            return this.DateOfAdmition.Equals(other.DateOfAdmition) && this.DateOfDischarge.Equals(other.DateOfDischarge)
                && this.Reason.Equals(other.Reason) && this.Patient.Equals(other.Patient) && this.Physitian.Equals(other.Physitian);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "patient: " + patient.FullName + "\nphysitian: " + physitian.FullName + "\ndate of admition:"
                + dateOfAdmition.ToString("dd.MM.yyyy.") + "\ndate of discharge:" + dateOfDischarge.ToString("dd.MM.yyyy.")
                + "\nreason: " + reason;
        }
    }
}