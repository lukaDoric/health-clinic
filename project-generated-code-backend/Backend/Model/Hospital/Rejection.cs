// File:    Rejection.cs
// Author:  Vladimir
// Created: Monday, May 25, 2020 17:06:42
// Purpose: Definition of Class Rejection

using System;
using System.Collections.Generic;

namespace Model.Hospital
{
    public class Rejection
    {
        private String reason;
        private Medicine medicine;

        public string Reason { get => reason; }
        public Medicine Medicine { get => medicine; }

        public Rejection(string reason, Medicine medicine)
        {
            this.reason = reason;
            this.medicine = medicine;
        }

        public override bool Equals(object obj)
        {
            Rejection other = obj as Rejection;
            if(other == null)
            {
                return false;
            }
            return this.Reason.Equals(other.Reason) && this.Medicine.Equals(other.Medicine);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "medicine: " + this.Medicine.ToString() + "\nreason: " + this.Reason;
        }
    }
}