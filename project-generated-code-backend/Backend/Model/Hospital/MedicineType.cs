// File:    MedicineType.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class MedicineType

using System;

namespace Model.Hospital
{
    public class MedicineType
    {
        private String type;

        public string Type { get => type; }

        public MedicineType(string type)
        {
            this.type = type;
        }
        public override bool Equals(object obj)
        {
            MedicineType other = obj as MedicineType;
            if(other == null)
            {
                return false;
            }
            return this.Type.Equals(other.Type);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "type: " + this.Type;
        }
    }
}