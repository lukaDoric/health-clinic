// File:    Bed.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Bed

using System;

namespace Model.Hospital
{
   public class Bed : Equipment
   {
        public Bed(string name, string id) : base(name, id)
        {

        }
   }
}