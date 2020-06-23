// File:    Medicine.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Medicine

using System;

namespace Model.Hospital
{
    public class Medicine
    {
        private String copyrightName;
        private String genericName;
        private MedicineManufacturer medicineManufacturer;
        private MedicineType medicineType;

        public string CopyrightName { get => copyrightName; }
        public string GenericName { get => genericName; }
        public MedicineManufacturer MedicineManufacturer { get => medicineManufacturer; }
        public MedicineType MedicineType { get => medicineType; }

        public Medicine(string copyrightName, string genericName, MedicineManufacturer medicineManufacturer, MedicineType medicineType)
        {
            this.copyrightName = copyrightName;
            this.genericName = genericName;
            this.medicineManufacturer = medicineManufacturer;
            this.medicineType = medicineType;
        }

        public override bool Equals(object obj)
        {
            Medicine other = obj as Medicine;

            if(other == null)
            {
                return false;
            }

            return this.CopyrightName.Equals(other.CopyrightName);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "copyright name: " + this.CopyrightName + "\ngeneric name: " + this.GenericName
                + "\nmedicineManufacturer: " + this.MedicineManufacturer.ToString() + "\nmedicineType: " + this.MedicineType.ToString();
        }
    }
}