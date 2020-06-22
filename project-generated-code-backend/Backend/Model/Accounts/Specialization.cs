// File:    Specialization.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Specialization

using System;

namespace Model.Accounts
{
    public class Specialization
    {
        private String name;

        public Specialization(string name)
        {
            this.name = name;
        }

        public string Name { get => name; }
    }
}