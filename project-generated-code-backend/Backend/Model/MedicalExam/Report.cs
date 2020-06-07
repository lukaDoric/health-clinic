// File:    Report.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Report

using System;

namespace Backend.Model.MedicalExam
{
   public class Report
   {
      private DateTime date;
      private String findings;
      
      private Backend.Model.Accounts.Patient patient;
      private Backend.Model.Accounts.Physitian physitian;
      private System.Collections.Generic.List<AdditionalDocument> additionalDocument;
      
      /// <summary>
      /// Property for collection of AdditionalDocument
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<AdditionalDocument> AdditionalDocument
      {
         get
         {
            if (additionalDocument == null)
               additionalDocument = new System.Collections.Generic.List<AdditionalDocument>();
            return additionalDocument;
         }
         set
         {
            RemoveAllAdditionalDocument();
            if (value != null)
            {
               foreach (AdditionalDocument oAdditionalDocument in value)
                  AddAdditionalDocument(oAdditionalDocument);
            }
         }
      }
      
      /// <summary>
      /// Add a new AdditionalDocument in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAdditionalDocument(AdditionalDocument newAdditionalDocument)
      {
         if (newAdditionalDocument == null)
            return;
         if (this.additionalDocument == null)
            this.additionalDocument = new System.Collections.Generic.List<AdditionalDocument>();
         if (!this.additionalDocument.Contains(newAdditionalDocument))
         {
            this.additionalDocument.Add(newAdditionalDocument);
            newAdditionalDocument.Report = this;
         }
      }
      
      /// <summary>
      /// Remove an existing AdditionalDocument from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAdditionalDocument(AdditionalDocument oldAdditionalDocument)
      {
         if (oldAdditionalDocument == null)
            return;
         if (this.additionalDocument != null)
            if (this.additionalDocument.Contains(oldAdditionalDocument))
            {
               this.additionalDocument.Remove(oldAdditionalDocument);
               oldAdditionalDocument.Report = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of AdditionalDocument from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAdditionalDocument()
      {
         if (additionalDocument != null)
         {
            System.Collections.ArrayList tmpAdditionalDocument = new System.Collections.ArrayList();
            foreach (AdditionalDocument oldAdditionalDocument in additionalDocument)
               tmpAdditionalDocument.Add(oldAdditionalDocument);
            additionalDocument.Clear();
            foreach (AdditionalDocument oldAdditionalDocument in tmpAdditionalDocument)
               oldAdditionalDocument.Report = null;
            tmpAdditionalDocument.Clear();
         }
      }
   
   }
}