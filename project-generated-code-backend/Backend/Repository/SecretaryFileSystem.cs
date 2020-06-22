// File:    SecretaryFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SecretaryFileSystem

using Model.Accounts;
using System;

namespace Backend.Repository
{
   public class SecretaryFileSystem : GenericFileRepository<Secretary>, SecretaryRepository
   {
   }
}