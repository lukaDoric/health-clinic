// File:    RoomType.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class RoomType

using System;

namespace Model.Hospital
{
    public class RoomType
    {
        private string name;
        public string Name { get => name; }

        public RoomType(string name)
        {
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            RoomType other = obj as RoomType;
            if(other == null)
            {
                return false;
            }
            return this.Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "name: " + this.Name;
        }
    }
}