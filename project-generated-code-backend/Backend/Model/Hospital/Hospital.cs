// File:    Hospital.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Hospital

using Model.Accounts;
using System;
using System.Collections.Generic;

namespace Model.Hospital
{
   public class Hospital
   {
      private String name;
      
      private Superintendent superintendent;
      private Secretary[] secretary;
      private List<Physitian> physitian;
      
      /// <summary>
      /// Property for collection of Model.Accounts.Physitian
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public List<Physitian> Physitian
      {
         get
         {
            if (physitian == null)
               physitian = new List<Physitian>();
            return physitian;
         }
         set
         {
            RemoveAllPhysitian();
            if (value != null)
            {
               foreach (Physitian oPhysitian in value)
                  AddPhysitian(oPhysitian);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Accounts.Physitian in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPhysitian(Physitian newPhysitian)
      {
         if (newPhysitian == null)
            return;
         if (this.physitian == null)
            this.physitian = new List<Physitian>();
         if (!this.physitian.Contains(newPhysitian))
            this.physitian.Add(newPhysitian);
      }
      
      /// <summary>
      /// Remove an existing Model.Accounts.Physitian from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePhysitian(Physitian oldPhysitian)
      {
         if (oldPhysitian == null)
            return;
         if (this.physitian != null)
            if (this.physitian.Contains(oldPhysitian))
               this.physitian.Remove(oldPhysitian);
      }
      
      /// <summary>
      /// Remove all instances of Model.Accounts.Physitian from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPhysitian()
      {
         if (physitian != null)
            physitian.Clear();
      }
      private List<Patient> patient;
      
      /// <summary>
      /// Property for collection of Model.Accounts.Patient
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public List<Patient> Patient
      {
         get
         {
            if (patient == null)
               patient = new List<Patient>();
            return patient;
         }
         set
         {
            RemoveAllPatient();
            if (value != null)
            {
               foreach (Patient oPatient in value)
                  AddPatient(oPatient);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Accounts.Patient in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPatient(Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patient == null)
            this.patient = new List<Patient>();
         if (!this.patient.Contains(newPatient))
            this.patient.Add(newPatient);
      }
      
      /// <summary>
      /// Remove an existing Model.Accounts.Patient from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePatient(Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patient != null)
            if (this.patient.Contains(oldPatient))
               this.patient.Remove(oldPatient);
      }
      
      /// <summary>
      /// Remove all instances of Model.Accounts.Patient from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPatient()
      {
         if (patient != null)
            patient.Clear();
      }
      private Room[] room;
      private Model.Util.Address address;
      private Model.Schedule.Schedule schedule;
      private System.Collections.Generic.List<Medicine> medicine;
      
      /// <summary>
      /// Property for collection of Medicine
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public List<Medicine> Medicine
      {
         get
         {
            if (medicine == null)
               medicine = new List<Medicine>();
            return medicine;
         }
         set
         {
            RemoveAllMedicine();
            if (value != null)
            {
               foreach (Medicine oMedicine in value)
                  AddMedicine(oMedicine);
            }
         }
      }
      
      /// <summary>
      /// Add a new Medicine in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicine(Medicine newMedicine)
      {
         if (newMedicine == null)
            return;
         if (this.medicine == null)
            this.medicine = new System.Collections.Generic.List<Medicine>();
         if (!this.medicine.Contains(newMedicine))
            this.medicine.Add(newMedicine);
      }
      
      /// <summary>
      /// Remove an existing Medicine from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicine(Medicine oldMedicine)
      {
         if (oldMedicine == null)
            return;
         if (this.medicine != null)
            if (this.medicine.Contains(oldMedicine))
               this.medicine.Remove(oldMedicine);
      }
      
      /// <summary>
      /// Remove all instances of Medicine from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicine()
      {
         if (medicine != null)
            medicine.Clear();
      }
   
   }
}