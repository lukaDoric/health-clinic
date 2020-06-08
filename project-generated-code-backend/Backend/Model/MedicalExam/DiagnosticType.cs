// File:    DiagnosticType.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class DiagnosticType

using System;

namespace Backend.Model.MedicalExam
{
    public class DiagnosticType
    {
        private String name;

        public string Name { get => name; }

        public DiagnosticType(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}