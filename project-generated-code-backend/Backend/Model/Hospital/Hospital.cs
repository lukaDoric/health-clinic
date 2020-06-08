// File:    Hospital.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Hospital

using Backend.Model.Accounts;
using Backend.Model.Util;
using System;

namespace Backend.Model.Hospital
{
   public class Hospital
   {
      private String name;
      
      private Backend.Model.Accounts.Superintendent superintendent;
      private Backend.Model.Accounts.Secretary[] secretary;
      private System.Collections.Generic.List<Physitian> physitian;
      
      /// <summary>
      /// Property for collection of Backend.Model.Accounts.Physitian
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Physitian> Physitian
      {
         get
         {
            if (physitian == null)
               physitian = new System.Collections.Generic.List<Physitian>();
            return physitian;
         }
         set
         {
            RemoveAllPhysitian();
            if (value != null)
            {
               foreach (Backend.Model.Accounts.Physitian oPhysitian in value)
                  AddPhysitian(oPhysitian);
            }
         }
      }
      
      /// <summary>
      /// Add a new Backend.Model.Accounts.Physitian in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPhysitian(Backend.Model.Accounts.Physitian newPhysitian)
      {
         if (newPhysitian == null)
            return;
         if (this.physitian == null)
            this.physitian = new System.Collections.Generic.List<Physitian>();
         if (!this.physitian.Contains(newPhysitian))
            this.physitian.Add(newPhysitian);
      }
      
      /// <summary>
      /// Remove an existing Backend.Model.Accounts.Physitian from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePhysitian(Backend.Model.Accounts.Physitian oldPhysitian)
      {
         if (oldPhysitian == null)
            return;
         if (this.physitian != null)
            if (this.physitian.Contains(oldPhysitian))
               this.physitian.Remove(oldPhysitian);
      }
      
      /// <summary>
      /// Remove all instances of Backend.Model.Accounts.Physitian from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPhysitian()
      {
         if (physitian != null)
            physitian.Clear();
      }
      private System.Collections.Generic.List<Patient> patient;
      
      /// <summary>
      /// Property for collection of Backend.Model.Accounts.Patient
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Patient> Patient
      {
         get
         {
            if (patient == null)
               patient = new System.Collections.Generic.List<Patient>();
            return patient;
         }
         set
         {
            RemoveAllPatient();
            if (value != null)
            {
               foreach (Backend.Model.Accounts.Patient oPatient in value)
                  AddPatient(oPatient);
            }
         }
      }
      
      /// <summary>
      /// Add a new Backend.Model.Accounts.Patient in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPatient(Backend.Model.Accounts.Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patient == null)
            this.patient = new System.Collections.Generic.List<Patient>();
         if (!this.patient.Contains(newPatient))
            this.patient.Add(newPatient);
      }
      
      /// <summary>
      /// Remove an existing Backend.Model.Accounts.Patient from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePatient(Backend.Model.Accounts.Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patient != null)
            if (this.patient.Contains(oldPatient))
               this.patient.Remove(oldPatient);
      }
      
      /// <summary>
      /// Remove all instances of Backend.Model.Accounts.Patient from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPatient()
      {
         if (patient != null)
            patient.Clear();
      }
      private Room[] room;
      private System.Collections.Generic.List<Address> adress;
      
      /// <summary>
      /// Property for collection of Backend.Model.Util.Adress
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Address> Adress
      {
         get
         {
            if (adress == null)
               adress = new System.Collections.Generic.List<Address>();
            return adress;
         }
         set
         {
            RemoveAllAdress();
            if (value != null)
            {
               foreach (Backend.Model.Util.Address oAdress in value)
                  AddAdress(oAdress);
            }
         }
      }
      
      /// <summary>
      /// Add a new Backend.Model.Util.Adress in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAdress(Backend.Model.Util.Address newAdress)
      {
         if (newAdress == null)
            return;
         if (this.adress == null)
            this.adress = new System.Collections.Generic.List<Address>();
         if (!this.adress.Contains(newAdress))
            this.adress.Add(newAdress);
      }
      
      /// <summary>
      /// Remove an existing Backend.Model.Util.Adress from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAdress(Backend.Model.Util.Address oldAdress)
      {
         if (oldAdress == null)
            return;
         if (this.adress != null)
            if (this.adress.Contains(oldAdress))
               this.adress.Remove(oldAdress);
      }
      
      /// <summary>
      /// Remove all instances of Backend.Model.Util.Adress from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAdress()
      {
         if (adress != null)
            adress.Clear();
      }
      private Backend.Model.Schedule.Schedule schedule;
      private System.Collections.Generic.List<Medicine> medicine;
      
      /// <summary>
      /// Property for collection of Medicine
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Medicine> Medicine
      {
         get
         {
            if (medicine == null)
               medicine = new System.Collections.Generic.List<Medicine>();
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