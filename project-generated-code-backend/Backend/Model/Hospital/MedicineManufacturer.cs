// File:    MedicineManufacturer.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class MedicineManufacturer

using System;

namespace Model.Hospital
{
    public class MedicineManufacturer
    {
        private String name;

        public string Name { get => name; }

        public MedicineManufacturer(string name)
        {
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            MedicineManufacturer other = obj as MedicineManufacturer;
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