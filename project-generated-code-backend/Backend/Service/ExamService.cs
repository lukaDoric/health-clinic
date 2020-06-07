// File:    ExamService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class ExamService

using Backend.Repository;
using System;

namespace Backend.Service
{
   public class ExamService
   {
      private Backend.Model.Accounts.Physitian loggedPhysitian;
      private Backend.Model.Accounts.Patient selectedPatient;
      private Backend.Model.MedicalExam.Report report;
      
      public void SaveReport()
      {
         throw new NotImplementedException();
      }
      
      public void NewSpecialistReferral()
      {
         throw new NotImplementedException();
      }
      
      public void NewFollowUp(Backend.Model.Accounts.Specialization specialization)
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
      
      public Backend.Repository.ReportRepository reportRepository;
      public System.Collections.Generic.List<AppointmentRepository> appointmentRepository;
      
      /// <summary>
      /// Property for collection of Backend.Repository.AppointmentRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<AppointmentRepository> AppointmentRepository
      {
         get
         {
            if (appointmentRepository == null)
               appointmentRepository = new System.Collections.Generic.List<AppointmentRepository>();
            return appointmentRepository;
         }
         set
         {
            RemoveAllAppointmentRepository();
            if (value != null)
            {
               foreach (Backend.Repository.AppointmentRepository oAppointmentRepository in value)
                  AddAppointmentRepository(oAppointmentRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Backend.Repository.AppointmentRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAppointmentRepository(Backend.Repository.AppointmentRepository newAppointmentRepository)
      {
         if (newAppointmentRepository == null)
            return;
         if (this.appointmentRepository == null)
            this.appointmentRepository = new System.Collections.Generic.List<AppointmentRepository>();
         if (!this.appointmentRepository.Contains(newAppointmentRepository))
            this.appointmentRepository.Add(newAppointmentRepository);
      }
      
      /// <summary>
      /// Remove an existing Backend.Repository.AppointmentRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAppointmentRepository(Backend.Repository.AppointmentRepository oldAppointmentRepository)
      {
         if (oldAppointmentRepository == null)
            return;
         if (this.appointmentRepository != null)
            if (this.appointmentRepository.Contains(oldAppointmentRepository))
               this.appointmentRepository.Remove(oldAppointmentRepository);
      }
      
      /// <summary>
      /// Remove all instances of Backend.Repository.AppointmentRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAppointmentRepository()
      {
         if (appointmentRepository != null)
            appointmentRepository.Clear();
      }
   
   }
}