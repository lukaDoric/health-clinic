// File:    AppointmentDTO.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentDTO

using Backend.Model.Accounts;
using Backend.Model.Hospital;
using Backend.Model.Schedule;
using Backend.Model.Util;
using System;

namespace Backend.Dto
{
    public class AppointmentDTO
    {
        private bool IsPreferedPhysitianSelected()
        {
            return (Physitian != null);
        }

        private bool IsPreferedDateTimeSelected()
        {
            return (DateTime != null);
        }

        private bool IsPreferedRoomSelected()
        {
            return (Room != null);
        }

        private ProcedureType procedureType;
        private TimeInterval dateTime;
        private Physitian physitian;
        private Patient patient;
        private Room room;
        private bool urgency;
        private bool timeRestriction;

        public ProcedureType ProcedureType { get => procedureType; set => procedureType = value; }
        public TimeInterval DateTime { get => dateTime; set => dateTime = value; }
        public Physitian Physitian { get => physitian; set => physitian = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public Room Room { get => room; set => room = value; }
        public bool Urgency { get => urgency; set => urgency = value; }
        public bool TimeRestriction { get => timeRestriction; set => timeRestriction = value; }
    }
}