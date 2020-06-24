// File:    SpecialistReferral.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class SpecialistReferral

using Model.Accounts;
using Newtonsoft.Json;
using System;

namespace Model.MedicalExam
{
    public class SpecialistReferral : AdditionalDocument
    {
        private static int serialNumberGenerator = 0;
        private Specialization specialization;
        private Physitian physitian;

        public Specialization Specialization { get => specialization; }
        public Physitian Physitian { get => physitian; }

        public SpecialistReferral(DateTime date, string notes, Specialization specialization, Physitian physitian) : base(serialNumberGenerator++, date, notes)
        {
            this.specialization = specialization;
            this.physitian = physitian;
        }

        [JsonConstructor]
        public SpecialistReferral(int serialNumber, DateTime date, string notes, Specialization specialization, Physitian physitian) : base(serialNumber, date, notes)
        {
            this.specialization = specialization;
            this.physitian = physitian;
        }

        public override bool Equals(object obj)
        {
            SpecialistReferral other = obj as SpecialistReferral;
            if (other == null)
            {
                return false;
            }
            return base.Equals(obj) && this.Physitian.Equals(other.Physitian) && this.Specialization.Equals(other.Specialization);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + "\nphysitian: " + this.Physitian.FullName
                + "\nspecialization: " + this.specialization;
        }
    }
}