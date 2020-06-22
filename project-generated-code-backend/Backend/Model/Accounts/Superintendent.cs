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
        public Superintendent(string name, string surname, string id, DateTime dateOfBirth, string contact, string email, Address address)
            : base(name, surname, id, dateOfBirth, contact, email, address)
        {

        }
    }
}