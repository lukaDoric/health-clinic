// File:    Appointment.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Appointment

using Backend.Model.Accounts;
using Backend.Model.Hospital;
using Backend.Model.Util;
using System;

namespace Backend.Model.Schedule
{
    public class Appointment
    {
        private Backend.Model.Hospital.Room room;
        private Backend.Model.Accounts.Physitian physitian;
        private Backend.Model.Accounts.Patient patient;
        private Backend.Model.Util.TimeInterval timeInterval;
        private ProcedureType procedureType;

        public Room Room { get => room;}
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
    }
}