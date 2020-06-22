// File:    Room.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Room

using Model.Util;
using System;
using System.Collections.Generic;

namespace Model.Hospital
{
    public class Room
    {
        private int id;

        private RoomType roomType;
        private List<TimeInterval> renovationTime;
        private List<Equipment> equipment;

        public RoomType RoomType { get => roomType; }
        public int Id { get => id; }

        /// <summary>
        /// Property for collection of Equipment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<Equipment> Equipment
        {
            get
            {
                if (equipment == null)
                    equipment = new List<Equipment>();
                return equipment;
            }
            set
            {
                RemoveAllEquipment();
                if (value != null)
                {
                    foreach (Equipment oEquipment in value)
                        AddEquipment(oEquipment);
                }
            }
        }

        /// <summary>
        /// Add a new Equipment in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddEquipment(Equipment newEquipment)
        {
            if (newEquipment == null)
                return;
            if (this.equipment == null)
                this.equipment = new List<Equipment>();
            if (!this.equipment.Contains(newEquipment))
                this.equipment.Add(newEquipment);
        }

        /// <summary>
        /// Remove an existing Equipment from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveEquipment(Equipment oldEquipment)
        {
            if (oldEquipment == null)
                return;
            if (this.equipment != null)
                if (this.equipment.Contains(oldEquipment))
                    this.equipment.Remove(oldEquipment);
        }

        /// <summary>
        /// Remove all instances of Equipment from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllEquipment()
        {
            if (equipment != null)
                equipment.Clear();
        }

        //------------------------------------------------------------
        /// <summary>
        /// Property for collection of TimeInterval
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<TimeInterval> RenovationTime
        {
            get
            {
                if (renovationTime == null)
                    renovationTime = new List<TimeInterval>();
                return renovationTime;
            }
            set
            {
                RemoveAllRenovationTime();
                if (value != null)
                {
                    foreach (TimeInterval oRenovationTime in value)
                        AddRenovationTime(oRenovationTime);
                }
            }
        }


        /// <summary>
        /// Add a new TimeInterval in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddRenovationTime(TimeInterval newRenovationTime)
        {
            if (newRenovationTime == null)
                return;
            if (this.renovationTime == null)
                this.renovationTime = new List<TimeInterval>();
            if (!this.renovationTime.Contains(newRenovationTime))
                this.renovationTime.Add(newRenovationTime);
        }

        /// <summary>
        /// Remove an existing TimeInterval from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveRenovationTime(TimeInterval oldRenovationTime)
        {
            if (oldRenovationTime == null)
                return;
            if (this.renovationTime != null)
                if (this.renovationTime.Contains(oldRenovationTime))
                    this.renovationTime.Remove(oldRenovationTime);
        }

        /// <summary>
        /// Remove all instances of Equipment from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllRenovationTime()
        {
            if (renovationTime != null)
                renovationTime.Clear();
        }

        public Room(int id, RoomType roomType)
        {
            this.id = id;
            this.roomType = roomType;
            this.equipment = new List<Equipment>();
            this.renovationTime = new List<TimeInterval>();
        }

        public override bool Equals(object obj)
        {
            Room other = obj as Room;
            if(other == null)
            {
                return false;
            }
            return this.Id.Equals(other.Id) && this.RoomType.Equals(other.RoomType);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string ret = "id: " + this.id + "\nroom type: " + this.roomType.ToString();

            ret += "\nequipment:\n";
            foreach(Equipment e in equipment)
            {
                ret += "\t" + e.ToString();
            }
            ret += "\nrenovation time: ";
            foreach(TimeInterval r in renovationTime)
            {
                ret += "\t" + r.ToString();
            }
            return ret;
        }
    }
}