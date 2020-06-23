// File:    Equipment.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Equipment

using System;

namespace Model.Hospital
{
    public class Equipment
    {
        private String name;
        private String id;

        public Equipment(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public Equipment(Equipment equipment)
        {
            this.name = equipment.name;
            this.id = equipment.id;
        }

        public string Name { get => name; }
        public string Id { get => id; }

        public override bool Equals(object obj)
        {
            Equipment other = obj as Equipment;

            if(other == null)
            {
                return false;
            }

            return this.Name.Equals(other.Name) && this.Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "name: " + this.Name + "\nid: " + this.Id;
        }
    }
}