// File:    SpecialistReferral.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SpecialistReferral

using System;

namespace Backend.Model.MedicalExam
{
   public class SpecialistReferral : AdditionalDocument
   {
      private Backend.Model.Accounts.Specialization specialization;
      private Backend.Model.Accounts.Physitian physitian;
   
   }
}