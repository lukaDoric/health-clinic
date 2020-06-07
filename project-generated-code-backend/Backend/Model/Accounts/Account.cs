// File:    Account.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Account

using Backend.Model.Blog;
using Backend.Model.Util;
using System;

namespace Backend.Model.Accounts
{
   public abstract class Account
   {
      protected String name;
      protected String surname;
      protected String id;
      protected DateTime dateOfBirth;
      protected String contact;
      
      protected System.Collections.Generic.List<Adress> adress;
      
      /// <summary>
      /// Property for collection of Backend.Model.Util.Adress
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Adress> Adress
      {
         get
         {
            if (adress == null)
               adress = new System.Collections.Generic.List<Adress>();
            return adress;
         }
         set
         {
            RemoveAllAdress();
            if (value != null)
            {
               foreach (Backend.Model.Util.Adress oAdress in value)
                  AddAdress(oAdress);
            }
         }
      }
      
      /// <summary>
      /// Add a new Backend.Model.Util.Adress in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAdress(Backend.Model.Util.Adress newAdress)
      {
         if (newAdress == null)
            return;
         if (this.adress == null)
            this.adress = new System.Collections.Generic.List<Adress>();
         if (!this.adress.Contains(newAdress))
            this.adress.Add(newAdress);
      }
      
      /// <summary>
      /// Remove an existing Backend.Model.Util.Adress from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAdress(Backend.Model.Util.Adress oldAdress)
      {
         if (oldAdress == null)
            return;
         if (this.adress != null)
            if (this.adress.Contains(oldAdress))
               this.adress.Remove(oldAdress);
      }
      
      /// <summary>
      /// Remove all instances of Backend.Model.Util.Adress from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAdress()
      {
         if (adress != null)
            adress.Clear();
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
   
   }
}