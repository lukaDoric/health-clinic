// File:    Account.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Account

using Backend.Model.Blog;
using Backend.Model.Util;
using System;
using System.Collections.Generic;

namespace Backend.Model.Accounts
{
   public abstract class Account
   {
        protected String name;
        protected String surname;
        protected String id;
        protected DateTime dateOfBirth;
        protected String contact;

        protected System.Collections.Generic.List<Address> address;

        protected Account(string name, string surname, string id, DateTime dateOfBirth, string contact, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.contact = contact;
            this.address = new List<Address>();
            this.address.Add(address);
        }



        /// <summary>
        /// Property for collection of Backend.Model.Util.Adress
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Address> Adress
        {
            get
            {
                if (address == null)
                    address = new System.Collections.Generic.List<Address>();
                return address;
            }
            set
            {
                RemoveAllAdress();
                if (value != null)
                {
                    foreach (Backend.Model.Util.Address oAdress in value)
                        AddAdress(oAdress);
                }
            }
        }

        /// <summary>
        /// Add a new Backend.Model.Util.Adress in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddAdress(Backend.Model.Util.Address newAdress)
        {
            if (newAdress == null)
                return;
            if (this.address == null)
                this.address = new System.Collections.Generic.List<Address>();
            if (!this.address.Contains(newAdress))
                this.address.Add(newAdress);
        }

        /// <summary>
        /// Remove an existing Backend.Model.Util.Adress from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveAdress(Backend.Model.Util.Address oldAdress)
        {
            if (oldAdress == null)
                return;
            if (this.address != null)
                if (this.address.Contains(oldAdress))
                    this.address.Remove(oldAdress);
        }

        /// <summary>
        /// Remove all instances of Backend.Model.Util.Adress from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllAdress()
        {
            if (address != null)
                address.Clear();
        }
        protected System.Collections.Generic.List<Comment> comment;

        /// <summary>
        /// Property for collection of Comment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Comment> Comment
        {
            get
            {
                if (comment == null)
                    comment = new System.Collections.Generic.List<Comment>();
                return comment;
            }
            set
            {
                RemoveAllComment();
                if (value != null)
                {
                    foreach (Comment oComment in value)
                        AddComment(oComment);
                }
            }
        }

        public string Name { get => name; }
        public string Surname { get => surname; }
        public string Id { get => id; }
        public DateTime DateOfBirth { get => dateOfBirth; }
        public string Contact { get => contact; }

        /// <summary>
        /// Add a new Comment in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddComment(Comment newComment)
        {
            if (newComment == null)
                return;
            if (this.comment == null)
                this.comment = new System.Collections.Generic.List<Comment>();
            if (!this.comment.Contains(newComment))
            {
                this.comment.Add(newComment);
                newComment.Account = this;
            }
        }

        /// <summary>
        /// Remove an existing Comment from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveComment(Comment oldComment)
        {
            if (oldComment == null)
                return;
            if (this.comment != null)
                if (this.comment.Contains(oldComment))
                {
                    this.comment.Remove(oldComment);
                    oldComment.Account = null;
                }
        }

        /// <summary>
        /// Remove all instances of Comment from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllComment()
        {
            if (comment != null)
            {
                System.Collections.ArrayList tmpComment = new System.Collections.ArrayList();
                foreach (Comment oldComment in comment)
                    tmpComment.Add(oldComment);
                comment.Clear();
                foreach (Comment oldComment in tmpComment)
                    oldComment.Account = null;
                tmpComment.Clear();
            }
        }
        public override string ToString()
        {
            return name + " " + surname;
        }
    }
}