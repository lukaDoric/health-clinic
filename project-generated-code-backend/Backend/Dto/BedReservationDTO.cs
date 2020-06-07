// File:    BedReservationDTO.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class BedReservationDTO

using Backend.Model.Accounts;
using Backend.Model.Hospital;
using Backend.Model.Util;
using System;

namespace Backend.Dto
{
   public class BedReservationDTO
   {
      private Bed bed;
      private Patient patient;
      private TimeInterval timeInterval;
   
   }
}