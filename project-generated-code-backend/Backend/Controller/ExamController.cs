// File:    ExamController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ExamController

using Model.Accounts;
using Model.MedicalExam;
using System;

namespace Backend.Controller
{
   public class ExamController
   {
      private Physitian loggedPhysitian;
      private Patient selectedPatient;
      
      public void NewReport(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void NewSpecialistReferral(Report report)
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