// File:    GenericFileRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class GenericFileRepository

using System;
using System.Collections.Generic;

namespace Backend.Repository
{
   public class GenericFileRepository<T> : GenericRepository<T>
   {
      private String path;

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Save(T newEntity)
        {
            throw new NotImplementedException();
        }

        public void Update(T updateEntity)
        {
            throw new NotImplementedException();
        }
    }
}