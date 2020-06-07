// File:    InpatientCare.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCare

using System;

namespace Backend.Model.MedicalExam
{
   public class InpatientCare
   {
      private DateTime dateOfAdmition;
      private DateTime dateOfDischarge;
      private String reason;
      
      private Backend.Model.Accounts.Physitian physitian;
      private Backend.Model.Accounts.Patient patient;
      
      public void GenerateAdmissionNote()
      {
         throw new NotImplementedException();
      }
      
      public void GenerateDischargeNote()
      {
         throw new NotImplementedException();
      }
   
   }
}