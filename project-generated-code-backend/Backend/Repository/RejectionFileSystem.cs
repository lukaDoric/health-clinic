// File:    RejectionFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class RejectionFileSystem

using Model.Hospital;
using System;

namespace Backend.Repository
{
   public class RejectionFileSystem : GenericFileRepository<Rejection>, RejectionRepository
   {
   }
}