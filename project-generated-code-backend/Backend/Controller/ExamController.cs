// File:    ExamController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ExamController

using System;

namespace Backend.Controller
{
   public class ExamController
   {
      private Backend.Model.Accounts.Physitian loggedPhysitian;
      private Backend.Model.Accounts.Patient selectedPatient;
      
      public void NewReport(Backend.Model.Accounts.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void NewSpecialistReferral(Backend.Model.MedicalExam.Report report)
      {
         throw new NotImplementedException();
      }
      
      public void NewFollowUp()
      {
         throw new NotImplementedException();
      }
      
      public void NewPrescription()
      {
         throw new NotImplementedException();
      }
      
      public void NewDiagnosticReferral()
      {
         throw new NotImplementedException();
      }
      
      public Backend.Service.ExamService examService;
   
   }
}