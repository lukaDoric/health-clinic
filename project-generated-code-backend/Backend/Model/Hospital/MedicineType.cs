// File:    MedicineType.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class MedicineType

using Backend.Model.Util;
using Newtonsoft.Json;
using System;

namespace Model.Hospital
{
    public class MedicineType : Entity
    {
        private static int serialNumberGenerator = 0;
        private String type;

        public string Type { get => type; }

        public MedicineType(string type) : base(serialNumberGenerator++)
        {
            this.type = type;
        }

        [JsonConstructor]
        public MedicineType(int serialNumber, string type) : base(serialNumber)
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