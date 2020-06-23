// File:    GenericFileRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class GenericFileRepository

using Backend.Model.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Backend.Repository
{
   public abstract class GenericFileSystem<T> : GenericRepository<T> where T : Entity
   {
      protected String path;

        public void Delete(int id)
        {
            List<T> entities = GetAll();
            T entity = GetById(id);
            entities.Remove(entity);
            SaveAll(entities);
        }

        public List<T> GetAll()
        {
            List<T> entities = new List<T>();
            String[] lines = File.ReadAllLines(path);
            foreach (String line in lines)
            {
                Console.WriteLine(line);
                entities.Add(Instantiate(line)); //u svaku implementaciju Instantiate JsonConvert.DeserializeObject<T>(line);
            }
            return entities;
        }

        public T GetById(int id)
        {
            foreach(T entity in GetAll())
            {
                if(entity.SerialNumber == id)
                {
                    return entity;
                }
            }
            return null;
        }

        public void Save(T newEntity)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            StreamWriter sw = new StreamWriter(path);
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, newEntity);
            writer.WriteRaw("\n");
        }

        public void Update(T updateEntity)
        {
            Delete(updateEntity.SerialNumber);
            Save(updateEntity);
        }

        public abstract T Instantiate(string objectStringFormat);

        private void SaveAll(List<T> entities)
        {
            foreach (T e in entities)
            {
                Save(e);
            }
        }
    }
}