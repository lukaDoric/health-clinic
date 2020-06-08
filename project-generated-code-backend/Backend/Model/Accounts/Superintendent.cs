// File:    Superintendent.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Superintendent

using Backend.Model.Util;
using System;

namespace Backend.Model.Accounts
{
   public class Superintendent : Account
   {
        public Superintendent(string name, string surname, string id, DateTime dateOfBirth, string contact, Address address) : base(name, surname, id, dateOfBirth, contact, address)
        {

        }
   }
}