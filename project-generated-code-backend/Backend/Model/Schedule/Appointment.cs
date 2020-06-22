// File:    Appointment.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class Appointment

using Model.Accounts;
using Model.Hospital;
using Model.Util;
using System;

namespace Model.Schedule
{
    public class Appointment
    {
        private Room room;
        private Physitian physitian;
        private Patient patient;
        private TimeInterval timeInterval;
        private ProcedureType procedureType;

        public Room Room { get => room; }
        public Physitian Physitian { get => physitian; }
        public Patient Patient { get => patient; }
        public TimeInterval TimeInterval { get => timeInterval; }
        public ProcedureType ProcedureType { get => procedureType; }

        public Appointment(Room room, Physitian physitian, Patient patient, TimeInterval timeInterval, ProcedureType procedureType)
        {
            this.room = room;
            this.physitian = physitian;
            this.patient = patient;
            this.timeInterval = timeInterval;
            this.procedureType = procedureType;
        }

        public override bool Equals(object obj)
        {
            Appointment other = obj as Appointment;
            if(other == null)
            {
                return false;
            }
            return this.Room.Equals(other.Room) && this.Physitian.Equals(other.Physitian) && this.Patient.Equals(this.Patient)
                && this.TimeInterval.Equals(other.TimeInterval) && this.ProcedureType.Equals(other.ProcedureType);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "patient: " + patient.FullName + "\nphysitian: " + physitian.FullName + "\ntime interval: "
                + timeInterval.ToString() + "\nroom: " + room.ToString() + "\nprocedure type: " + procedureType.ToString();
        }
    }
}