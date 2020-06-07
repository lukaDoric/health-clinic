// File:    InpatientCareFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCareFileSystem

using System;

namespace Backend.Repository
{
   public class InpatientCareFileSystem : GenericFileRepository<T>, InpatientCareRepository
   {
   }
}