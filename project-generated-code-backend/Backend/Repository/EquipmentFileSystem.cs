// File:    EquipmentFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class EquipmentFileSystem

using Model.Hospital;
using Newtonsoft.Json;
using System;

namespace Backend.Repository
{
    public class EquipmentFileSystem : GenericFileSystem<Equipment>, EquipmentRepository
    {
        EquipmentFileSystem()
        {
            path = @"./../../../../project-generated-code-backend/data/equipment.txt";
        }
        public override Equipment Instantiate(string objectStringFormat)
        {
            return JsonConvert.DeserializeObject<Equipment>(objectStringFormat);
        }
    }
}