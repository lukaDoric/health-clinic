// File:    BedReservation.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class BedReservation

using Model.Accounts;
using Model.Util;
using System;

namespace Model.Hospital
{
    public class BedReservation
    {
        private TimeInterval timeInterval;
        private Patient patient;
        private Bed bed;

        /// <summary>
        /// Property for Bed
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Bed Bed
        {
            get
            {
                return bed;
            }
        }

        public Patient Patient { get => patient; }
        public TimeInterval TimeInterval { get => timeInterval; }

        public BedReservation(TimeInterval timeInterval, Patient patient, Bed bed)
        {
            this.timeInterval = timeInterval;
            this.patient = patient;
            this.bed = bed;
        }

        public override bool Equals(object obj)
        {
            BedReservation other = obj as BedReservation;

            if(other == null)
            {
                return false;
            }

            return this.Patient.Equals(other.Patient) && this.TimeInterval.Equals(other.TimeInterval)
                && this.Bed.Equals(other.Bed);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "patient: " + this.Patient.FullName + "\nbed: " + this.Bed.ToString() + "\ntime interval: "
                + this.TimeInterval.ToString();
        }
    }
}