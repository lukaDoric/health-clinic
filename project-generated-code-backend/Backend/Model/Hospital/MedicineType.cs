// File:    MedicineType.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class MedicineType

using System;

namespace Backend.Model.Hospital
{
   public class MedicineType
   {
        private String type;
        public string Type { get => type; }

        public override string ToString()
        {
            return type;
        }
    }
}