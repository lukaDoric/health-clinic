// File:    DiagnosticType.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class DiagnosticType

using Backend.Model.Util;
using System;

namespace Model.MedicalExam
{
    public class DiagnosticType : Entity
    {
        private static int serialNumberGenerator = 0;
        private String name;

        public string Name { get => name; }

        public DiagnosticType(string name) : base(serialNumberGenerator++)
        {
            this.name = name;
        }
        public DiagnosticType(int serialNumber, string name) : base(serialNumber)
        {
            this.name = name;
        }
        public override bool Equals(object obj)
        {
            DiagnosticType other = obj as DiagnosticType;
            if(other == null)
            {
                return false;
            }
            return this.Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "name: " + this.Name;
        }
    }
}