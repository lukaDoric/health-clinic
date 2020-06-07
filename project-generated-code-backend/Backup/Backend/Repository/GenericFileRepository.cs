// File:    GenericFileRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class GenericFileRepository

using System;

namespace Backend.Repository
{
   public class GenericFileRepository<T> : GenericRepository<T>
   {
      private String path;
   
   }
}