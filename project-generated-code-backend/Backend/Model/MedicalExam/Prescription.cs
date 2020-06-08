// File:    Prescription.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Prescription

using System;

namespace Backend.Model.MedicalExam
{
    public class Prescription : AdditionalDocument
    {
        private System.Collections.Generic.List<MedicineDosage> medicineDosage;

        public Prescription(DateTime date, string notes, Report report) : base(date, notes, report)
        {
        }

        /// <summary>
        /// Property for collection of MedicineDosage
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<MedicineDosage> MedicineDosage
        {
            get
            {
                if (medicineDosage == null)
                    medicineDosage = new System.Collections.Generic.List<MedicineDosage>();
                return medicineDosage;
            }
            set
            {
                RemoveAllMedicineDosage();
                if (value != null)
                {
                    foreach (MedicineDosage oMedicineDosage in value)
                        AddMedicineDosage(oMedicineDosage);
                }
            }
        }

        /// <summary>
        /// Add a new MedicineDosage in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddMedicineDosage(MedicineDosage newMedicineDosage)
        {
            if (newMedicineDosage == null)
                return;
            if (this.medicineDosage == null)
                this.medicineDosage = new System.Collections.Generic.List<MedicineDosage>();
            if (!this.medicineDosage.Contains(newMedicineDosage))
                this.medicineDosage.Add(newMedicineDosage);
        }

        /// <summary>
        /// Remove an existing MedicineDosage from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveMedicineDosage(MedicineDosage oldMedicineDosage)
        {
            if (oldMedicineDosage == null)
                return;
            if (this.medicineDosage != null)
                if (this.medicineDosage.Contains(oldMedicineDosage))
                    this.medicineDosage.Remove(oldMedicineDosage);
        }

        /// <summary>
        /// Remove all instances of MedicineDosage from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllMedicineDosage()
        {
            if (medicineDosage != null)
                medicineDosage.Clear();
        }

        public override string ToString()
        {
            String retVal = "";
            foreach(MedicineDosage dosage in MedicineDosage)
            {
                retVal += dosage.Medicine.ToString();
            }
            return retVal;
        }

    }
}