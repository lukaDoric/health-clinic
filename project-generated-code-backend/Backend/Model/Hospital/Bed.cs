// File:    Bed.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Bed

using Newtonsoft.Json;
using System;

namespace Model.Hospital
{
   public class Bed : Equipment
   {
        private static int serialNumberGenerator = 0;

        public Bed(string name, string id) : base(serialNumberGenerator++, name, id)
        {

        }

        [JsonConstructor]
        public Bed(int serialNumber, string name, string id) : base(serialNumber, name, id)
        {

        }
    }
}