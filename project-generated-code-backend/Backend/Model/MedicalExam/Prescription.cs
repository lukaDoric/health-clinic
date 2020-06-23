// File:    Prescription.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Prescription

using System;
using System.Collections.Generic;

namespace Model.MedicalExam
{
    public class Prescription : AdditionalDocument
    {
        private List<MedicineDosage> medicineDosage;

        public Prescription(DateTime date, string notes) : base(date, notes)
        {
            medicineDosage = new List<MedicineDosage>();
        }

        /// <summary>
        /// Property for collection of MedicineDosage
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<MedicineDosage> MedicineDosage
        {
            get
            {
                if (medicineDosage == null)
                    medicineDosage = new List<MedicineDosage>();
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
                this.medicineDosage = new List<MedicineDosage>();
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

        public override bool Equals(object obj)
        {
            Prescription other = obj as Prescription;
            if(other == null)
            {
                return false;
            }
            if(this.medicineDosage.Count != other.medicineDosage.Count)
            {
                return false;
            }
            foreach(MedicineDosage m in this.medicineDosage)
            {
                if(!other.medicineDosage.Contains(m))
                {
                    return false;
                }
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string ret = base.ToString();
            foreach(MedicineDosage m in medicineDosage)
            {
                ret += "\nmedicine dosage: " +  m.ToString();
            }
            return ret;
        }
    }
}