// File:    AdditionalDocument.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AdditionalDocument

using System;

namespace Backend.Model.MedicalExam
{
    public abstract class AdditionalDocument
    {
        protected DateTime date;
        protected String notes;

        protected Report report;

        /// <summary>
        /// Property for Report
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Report Report
        {
            get
            {
                return report;
            }
            set
            {
                if (this.report == null || !this.report.Equals(value))
                {
                    if (this.report != null)
                    {
                        Report oldReport = this.report;
                        this.report = null;
                        oldReport.RemoveAdditionalDocument(this);
                    }
                    if (value != null)
                    {
                        this.report = value;
                        this.report.AddAdditionalDocument(this);
                    }
                }
            }
        }

        public DateTime Date { get => date; }
        public string Notes { get => notes; set => notes = value; }

        protected AdditionalDocument(DateTime date, string notes, Report report)
        {
            this.date = date;
            this.notes = notes;
            this.report = report;
        }
    }
}