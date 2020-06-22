// File:    Patient.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Patient

using Model.Util;
using System;

namespace Model.Accounts
{
    public class Patient : Account
    {
        private String parentName;
        private String gender;

        public Patient(string name, string surname, string id, DateTime dateOfBirth, string contact, string email, Address address, string parentName, string gender)
            : base(name, surname, id, dateOfBirth, contact, email, address)
        {
            this.parentName = parentName;
            this.gender = gender;
        }

        public string ParentName { get => parentName; }
        public string Gender { get => gender; }

        public override string ToString()
        {
            return base.ToString() + "\nparent name: " + this.parentName + "\ngender: " + this.gender;
        }
    }
}