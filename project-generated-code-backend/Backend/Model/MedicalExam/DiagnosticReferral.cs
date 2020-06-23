// File:    DiagnosticReferral.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class DiagnosticReferral

using System;

namespace Model.MedicalExam
{
    public class DiagnosticReferral : AdditionalDocument
    {
        private static int serialNumberGenerator = 0;
        private DiagnosticType diagnosticType;

        /// <summary>
        /// Property for DiagnosticType
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public DiagnosticType DiagnosticType
        {
            get
            {
                return diagnosticType;
            }
            set
            {
                this.diagnosticType = value;
            }
        }
        public DiagnosticReferral(DateTime date, string notes, DiagnosticType diagnosticType) : base(serialNumberGenerator++, date, notes)
        {
            this.diagnosticType = diagnosticType;
        }
        public DiagnosticReferral(int serialNumber, DateTime date, string notes, DiagnosticType diagnosticType) : base(serialNumber, date, notes)
        {
            this.diagnosticType = diagnosticType;
        }
        public override bool Equals(object obj)
        {
            DiagnosticReferral other = obj as DiagnosticReferral;
            if(other == null)
            {
                return false;
            }
            return base.Equals(other) && this.DiagnosticType.Equals(other.DiagnosticType);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString() + "\ndiagnostic type: " + this.DiagnosticType.ToString();
        }
    }
}