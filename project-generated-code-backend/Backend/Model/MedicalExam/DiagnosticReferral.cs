// File:    DiagnosticReferral.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class DiagnosticReferral

using System;

namespace Backend.Model.MedicalExam
{
    public class DiagnosticReferral : AdditionalDocument
    {
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

        public DiagnosticReferral(DateTime date, string notes, Report report, DiagnosticType diagnosticType) : base(date, notes, report)
        {
            this.diagnosticType = diagnosticType;
        }

        public override string ToString()
        {
            return DiagnosticType.ToString();
        }
    }
}