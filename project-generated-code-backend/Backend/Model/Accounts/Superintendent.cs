// File:    Superintendent.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Superintendent

using Model.Util;
using System;

namespace Model.Accounts
{
    public class Superintendent : Account
    {
        private static int serialNumberGenerator = 0;
        public Superintendent(string name, string surname, string id, DateTime dateOfBirth, string contact, string email, Address address)
            : base(serialNumberGenerator++, name, surname, id, dateOfBirth, contact, email, address)
        {

        }

        public Superintendent(int serialNumber, string name, string surname, string id, DateTime dateOfBirth, string contact, string email, Address address)
            : base(serialNumber, name, surname, id, dateOfBirth, contact, email, address)
        {

        }
    }
}