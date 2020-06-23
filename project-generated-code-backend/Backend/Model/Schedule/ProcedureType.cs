// File:    ProcedureType.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class ProcedureType

using Model.Accounts;
using Model.Hospital;
using System;
using System.Collections.Generic;

namespace Model.Schedule
{
    public class ProcedureType
    {
        private String name;
        private Specialization specialization;
        private List<Equipment> requiredEquipment;

        /// <summary>
        /// Property for collection of Model.Hospital.Equipment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<Equipment> RequiredEquipment
        {
            get
            {
                if (requiredEquipment == null)
                    requiredEquipment = new List<Equipment>();
                return requiredEquipment;
            }
            set
            {
                RemoveAllRequiredEquipment();
                if (value != null)
                {
                    foreach (Equipment oEquipment in value)
                        AddRequiredEquipment(oEquipment);
                }
            }
        }

        public Specialization Specialization { get => specialization; }
        public string Name { get => name; }

        /// <summary>
        /// Add a new Model.Hospital.Equipment in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddRequiredEquipment(Equipment newEquipment)
        {
            if (newEquipment == null)
                return;
            if (this.requiredEquipment == null)
                this.requiredEquipment = new List<Equipment>();
            if (!this.requiredEquipment.Contains(newEquipment))
                this.requiredEquipment.Add(newEquipment);
        }

        /// <summary>
        /// Remove an existing Model.Hospital.Equipment from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveRequiredEquipment(Equipment oldEquipment)
        {
            if (oldEquipment == null)
                return;
            if (this.requiredEquipment != null)
                if (this.requiredEquipment.Contains(oldEquipment))
                    this.requiredEquipment.Remove(oldEquipment);
        }

        /// <summary>
        /// Remove all instances of Model.Hospital.Equipment from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllRequiredEquipment()
        {
            if (requiredEquipment != null)
                requiredEquipment.Clear();
        }

        public override bool Equals(object obj)
        {
            ProcedureType other = obj as ProcedureType;
            if (other == null)
            {
                return false;
            }
            if(this.RequiredEquipment.Count != other.RequiredEquipment.Count)
            {
                return false;
            }
            foreach(Equipment e in requiredEquipment)
            {
                if(!other.RequiredEquipment.Contains(e))
                {
                    return false;
                }
            }
            return this.Specialization.Equals(other.Specialization) && this.Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public ProcedureType(string name, Specialization specialization)
        {
            this.name = name;
            this.specialization = specialization;
            this.requiredEquipment = new List<Equipment>();
        }

        public override string ToString()
        {
            string ret = "name: " + name + "/nspecialization: " + specialization.ToString();
            foreach(Equipment e in requiredEquipment)
            {
                ret += "\nequipment: " + e.ToString();
            }
            return ret;
        }
    }
}