// File:    RenovationControler.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RenovationControler

using Backend.Dto;
using Backend.Service.HospitalResourcesService;
using System;
using System.Collections.Generic;

namespace Backend.Controller.SuperintendentControllers
{
   public class RenovationController
   {
      public Backend.Dto.RenovationDTO GetById(String id)
      {
         throw new NotImplementedException();
      }
      
      public List<RenovationDTO> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void EditRenovation(Backend.Dto.RenovationDTO renovation)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteRenovation(Backend.Dto.RenovationDTO renovation)
      {
         throw new NotImplementedException();
      }
      
      public void NewRenovation(Backend.Dto.RenovationDTO renovation)
      {
         throw new NotImplementedException();
      }
      
      public RenovationService renovationService;
   
   }
}