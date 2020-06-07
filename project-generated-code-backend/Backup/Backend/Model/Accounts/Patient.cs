// File:    Patient.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Patient

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
   
   }
}