// File:    Specialization.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Specialization

using System;

namespace Backend.Model.Accounts
{
   public class Specialization
   {
        private String name;

        private Physitian[] physitian;
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return name;
        }
    }
}