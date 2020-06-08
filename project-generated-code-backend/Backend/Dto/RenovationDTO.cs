// File:    RenovationDTO.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RenovationDTO

using Backend.Model.Hospital;
using Backend.Model.Util;
using System;

namespace Backend.Dto
{
    public class RenovationDTO
    {
        private Room room;
        private TimeInterval timeInterval;

        public Room Room { get => room; set => room = value; }
        public TimeInterval TimeInterval { get => timeInterval; set => timeInterval = value; }
    }
}