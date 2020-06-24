// File:    Specialization.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Specialization

using Backend.Model.Util;
using Newtonsoft.Json;
using System;

namespace Model.Accounts
{
    public class Specialization : Entity
    {
        private static int serialNumberGenerator = 0;
        private String name;

        public Specialization(string name) : base(serialNumberGenerator++)
        {
            this.name = name;
        }

        [JsonConstructor]
        public Specialization(int serialNumber, string name) : base(serialNumber)
        {
            this.name = name;
        }

        public string Name { get => name; }
    }
}