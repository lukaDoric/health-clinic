// File:    AppointmentGeneralitiesDTO.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentGeneralitiesDTO

using Backend.Model.Accounts;
using Backend.Model.Hospital;
using Backend.Model.Util;
using System;
using System.Collections.Generic;

namespace Backend.Dto
{
   public class AppointmentGeneralitiesDTO
   {
      private List<Physitian> availablePhysitians;
      private List<Room> availableRooms;
      private List<TimeInterval> availableTimeIntervals;
   
   }
}