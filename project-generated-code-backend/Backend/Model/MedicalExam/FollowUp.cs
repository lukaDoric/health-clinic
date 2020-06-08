// File:    FollowUp.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class FollowUp

using Backend.Model.Accounts;
using System;

namespace Backend.Model.MedicalExam
{
    public class FollowUp : AdditionalDocument
    {
        private Backend.Model.Accounts.Physitian physitian;

        public FollowUp(DateTime date, string notes, Report report, Physitian physitian) : base(date, notes, report)
        {
            this.physitian = physitian;
        }

        public Physitian Physitian { get => physitian; }

        public override string ToString()
        {
            return Physitian.ToString() + " " + Date.ToString("dd.MM.yyyy");
        }
    }
}