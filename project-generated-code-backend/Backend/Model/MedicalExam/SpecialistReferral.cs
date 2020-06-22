// File:    SpecialistReferral.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class SpecialistReferral

using Model.Accounts;
using System;

namespace Model.MedicalExam
{
    public class SpecialistReferral : AdditionalDocument
    {
        private Specialization specialization;
        private Physitian physitian;

        public Specialization Specialization { get => specialization; }
        public Physitian Physitian { get => physitian; }

        public SpecialistReferral(DateTime date, string notes, Specialization specialization, Physitian physitian) : base(date, notes)
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