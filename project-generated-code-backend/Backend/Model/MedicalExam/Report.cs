// File:    Report.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Report

using System;
using System.Collections.Generic;

namespace Model.MedicalExam
{
    public class Report
    {
        private DateTime date;
        private String findings;

        private List<AdditionalDocument> additionalDocument;

        /// <summary>
        /// Property for collection of AdditionalDocument
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<AdditionalDocument> AdditionalDocument
        {
            get
            {
                if (additionalDocument == null)
                    additionalDocument = new List<AdditionalDocument>();
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

        public DateTime Date { get => date; }
        public string Findings { get => findings; }

        /// <summary>
        /// Add a new AdditionalDocument in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddAdditionalDocument(AdditionalDocument newAdditionalDocument)
        {
            if (newAdditionalDocument == null)
                return;
            if (this.additionalDocument == null)
                this.additionalDocument = new List<AdditionalDocument>();
            if (!this.additionalDocument.Contains(newAdditionalDocument))
                this.additionalDocument.Add(newAdditionalDocument);
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
                    this.additionalDocument.Remove(oldAdditionalDocument);
        }

        /// <summary>
        /// Remove all instances of AdditionalDocument from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllAdditionalDocument()
        {
            if (additionalDocument != null)
                additionalDocument.Clear();
        }

        public Report(DateTime date, string findings, List<AdditionalDocument> additionalDocument)
        {
            this.date = date;
            this.findings = findings;
            this.additionalDocument = additionalDocument;
        }

        public override bool Equals(object obj)
        {
            Report other = obj as Report;
            if(other == null)
            {
                return false;
            }
            if(this.additionalDocument.Count != other.additionalDocument.Count)
            {
                return false;
            }
            foreach(AdditionalDocument doc in additionalDocument)
            {
                if(!other.additionalDocument.Contains(doc))
                {
                    return false;
                }
            }
            return this.Date.Equals(other.Date) && this.Findings.Equals(other.Findings);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string ret = "date: " + this.date.ToString("dd.MM.yyyy.") + "\nfindings: " + this.findings;
            foreach(AdditionalDocument doc in this.additionalDocument)
            {
                ret += "\ndocument: " + doc.ToString();
            }
            return ret;
        }
    }
}