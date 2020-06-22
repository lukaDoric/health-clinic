// File:    City.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class City

using System;

namespace Model.Util
{
    public class City
    {
        private String name;
        private String postalCode;

        private System.Collections.Generic.List<Address> address;

        /// <summary>
        /// Property for collection of Address
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Address> Address
        {
            get
            {
                if (address == null)
                    address = new System.Collections.Generic.List<Address>();
                return address;
            }
            set
            {
                RemoveAllAddress();
                if (value != null)
                {
                    foreach (Address oAddress in value)
                        AddAddress(oAddress);
                }
            }
        }

        public string Name { get => name; }
        public string PostalCode { get => postalCode; }

        public City(string name, string postalCode)
        {
            this.name = name;
            this.postalCode = postalCode;
        }



        /// <summary>
        /// Add a new Address in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddAddress(Address newAddress)
        {
            if (newAddress == null)
                return;
            if (this.address == null)
                this.address = new System.Collections.Generic.List<Address>();
            if (!this.address.Contains(newAddress))
                this.address.Add(newAddress);
        }

        /// <summary>
        /// Remove an existing Address from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveAddress(Address oldAddress)
        {
            if (oldAddress == null)
                return;
            if (this.address != null)
                if (this.address.Contains(oldAddress))
                    this.address.Remove(oldAddress);
        }

        /// <summary>
        /// Remove all instances of Address from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllAddress()
        {
            if (address != null)
                address.Clear();
        }

        public override string ToString()
        {
            return name + " " + postalCode;
        }

        public override bool Equals(object obj)
        {
            City other = obj as City;
            if (other == null)
            {
                return false;
            }
            return this.Name.Equals(other.Name) && this.postalCode.Equals(other.postalCode);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}