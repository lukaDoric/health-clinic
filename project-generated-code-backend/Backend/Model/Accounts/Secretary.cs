// File:    Secretary.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Secretary

using Backend.Model.Util;
using System;

namespace Backend.Model.Accounts
{
   public class Secretary : Account
   {
        public Secretary(string name, string surname, string id, DateTime dateOfBirth, string contact, Address address) : base(name, surname, id, dateOfBirth, contact, address)
        {

        }
   }
}