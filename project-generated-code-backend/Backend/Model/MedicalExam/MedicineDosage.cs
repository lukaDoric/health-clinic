// File:    MedicineDosage.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class MedicineDosage

using Model.Hospital;
using System;

namespace Model.MedicalExam
{
    public class MedicineDosage
    {
        private double amount;
        private String note;
        private Medicine medicine;

        /// <summary>
        /// Property for Model.Hospital.Medicine
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Medicine Medicine
        {
            get
            {
                return medicine;
            }
        }

        public double Amount { get => amount; }
        public string Note { get => note; }

        public MedicineDosage(double ammount, string note, Medicine medicine)
        {
            this.amount = ammount;
            this.note = note;
            this.medicine = medicine;
        }

        public override bool Equals(object obj)
        {
            MedicineDosage other = obj as MedicineDosage;
            if(other == null)
            {
                return false;
            }
            return this.Medicine.Equals(other.Medicine) && this.Amount == other.Amount && this.Medicine.Equals(other.Medicine);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "medicine: " + medicine.ToString() + "\namount: " + amount + "\nnote: " + note;
        }
    }
}