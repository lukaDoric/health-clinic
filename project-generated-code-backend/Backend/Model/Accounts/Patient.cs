// File:    Patient.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Patient

using Backend.Model.Hospital;
using Backend.Model.MedicalExam;
using Backend.Model.Schedule;
using Backend.Model.Util;
using System;

namespace Backend.Model.Accounts
{
   public class Patient : Account
   {
        private String parentName;
        private String gender;

        private BedReservation bedReservation;
        private Appointment[] appointment;
        private Report[] report;
        private InpatientCare[] inpatientCare;

        public Patient(string name, string surname, string id, DateTime dateOfBirth, string contact, Address address,string parentName, string gender) : base(name, surname, id, dateOfBirth, contact, address)
        {
            this.parentName = parentName;
            this.gender = gender;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}