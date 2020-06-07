// File:    EquipmentService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class EquipmentService

using Backend.Model.Hospital;
using System;
using System.Collections.Generic;

namespace Backend.Service
{
   public class EquipmentService
   {
      public Backend.Model.Hospital.Equipment GetById()
      {
         throw new NotImplementedException();
      }
      
      public List<Equipment> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void EditEquipment(Backend.Model.Hospital.Equipment equipment)
      {
         throw new NotImplementedException();
      }
      
      public void NewEquipment(Backend.Model.Hospital.Equipment equipment)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteEquipment(Backend.Model.Hospital.Equipment equipment)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Repository.EquipmentRepository equipmentRepository;
   
   }
}