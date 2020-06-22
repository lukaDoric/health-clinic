// File:    Physitian.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Physitian

using Model.Util;
using System;
using System.Collections.Generic;

namespace Model.Accounts
{
    public class Physitian : Account
    {
        private List<Specialization> specialization;
        public Physitian(string name, string surname, string id, DateTime dateOfBirth, string contact, string email, Address address)
            : base(name, surname, id, dateOfBirth, contact, email, address)
        {
            specialization = new List<Specialization>();
        }

        /// <summary>
        /// Property for collection of Specialization
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<Specialization> Specialization
        {
            get
            {
                if (specialization == null)
                    specialization = new List<Specialization>();
                return specialization;
            }
        }

        /// <summary>
        /// Add a new Specialization in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddSpecialization(Specialization newSpecialization)
        {
            if (newSpecialization == null)
                return;
            if (this.specialization == null)
                this.specialization = new List<Specialization>();
            if (!this.specialization.Contains(newSpecialization))
                this.specialization.Add(newSpecialization);
        }

        /// <summary>
        /// Remove an existing Specialization from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveSpecialization(Specialization oldSpecialization)
        {
            if (oldSpecialization == null)
                return;
            if (this.specialization != null)
                if (this.specialization.Contains(oldSpecialization))
                    this.specialization.Remove(oldSpecialization);
        }

        /// <summary>
        /// Remove all instances of Specialization from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllSpecialization()
        {
            if (specialization != null)
                specialization.Clear();
        }

        public override string ToString()
        {
            string ret = base.ToString();
            ret += "\nspecialization: ";
            foreach(Specialization s in specialization)
            {
                ret += s.Name + "\n";
            }
            return ret;
        }

    }
}