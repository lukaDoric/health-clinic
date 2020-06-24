// File:    Address.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Address

using Backend.Model.Util;
using Newtonsoft.Json;
using System;

namespace Model.Util
{
    public class Address : Entity
    {
        private static int serialNumberGenerator = 0;
        private String street;
        private int number;

        public string Street { get => street; }
        public int Number { get => number; }

        public Address(string street, int number) : base(serialNumberGenerator++)
        {
            this.street = street;
            this.number = number;
        }

        [JsonConstructor]
        public Address(int serialNumber, string street, int number) : base(serialNumber)
        {
            this.street = street;
            this.number = number;
        }

        public override string ToString()
        {
            return street + " " + number;
        }

        public override bool Equals(object obj)
        {
            Address other = obj as Address;
            if (other == null)
            {
                return false;
            }
            return this.Street.Equals(other.Street) && this.Number == other.Number;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}