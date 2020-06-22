// File:    AdditionalDocument.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class AdditionalDocument

using System;

namespace Model.MedicalExam
{
    public abstract class AdditionalDocument
    {
        protected DateTime date;
        protected String notes;

        public DateTime Date { get => date; }
        public string Notes { get => notes; }

        protected AdditionalDocument(DateTime date, string notes)
        {
            this.date = date;
            this.notes = notes;
        }

        public override bool Equals(object obj)
        {
            AdditionalDocument other = obj as AdditionalDocument;
            if(other == null)
            {
                return false;
            }
            return this.Date.Equals(other.Date) && this.Notes.Equals(other.Notes);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "date: " + this.Date.ToString("dd.MM.yyyy.") + "\nnotes: " + this.Notes;
        }
    }
}