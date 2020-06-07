// File:    BedReservationDTO.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class BedReservationDTO

using System;

namespace Backend.Dto
{
   public class BedReservationDTO
   {
      private Backend.Model.Hospital.Bed bed;
      private Backend.Model.Accounts.Patient patient;
      private Backend.Model.Util.TimeInterval timeInterval;
   
   }
}