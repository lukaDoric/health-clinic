// File:    Medicine.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Medicine

using Backend.Model.MedicalExam;
using System;

namespace Backend.Model.Hospital
{
    public class Medicine
    {
        private String copyrightName;
        private String genericName;

        private MedicineManufacturer medicineManufacturer;
        private MedicineType medicineType;
        private System.Collections.Generic.List<MedicineDosage> medicineDosage;

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

        public string CopyrightName { get => copyrightName; set => copyrightName = value; }
        public string GenericName { get => genericName; set => genericName = value; }
        public MedicineManufacturer MedicineManufacturer { get => medicineManufacturer; set => medicineManufacturer = value; }
        public MedicineType MedicineType { get => medicineType; set => medicineType = value; }

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
            {
                this.medicineDosage.Add(newMedicineDosage);
                newMedicineDosage.Medicine = this;
            }
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
                {
                    this.medicineDosage.Remove(oldMedicineDosage);
                    oldMedicineDosage.Medicine = null;
                }
        }

        /// <summary>
        /// Remove all instances of MedicineDosage from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllMedicineDosage()
        {
            if (medicineDosage != null)
            {
                System.Collections.ArrayList tmpMedicineDosage = new System.Collections.ArrayList();
                foreach (MedicineDosage oldMedicineDosage in medicineDosage)
                    tmpMedicineDosage.Add(oldMedicineDosage);
                medicineDosage.Clear();
                foreach (MedicineDosage oldMedicineDosage in tmpMedicineDosage)
                    oldMedicineDosage.Medicine = null;
                tmpMedicineDosage.Clear();
            }
        }

        public override string ToString()
        {
            return copyrightName;
        }
    }
}