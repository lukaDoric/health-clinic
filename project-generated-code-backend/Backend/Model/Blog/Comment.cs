// File:    Comment.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Comment

using System;

namespace Backend.Model.Blog
{
   public class Comment
   {
      private String text;
      private DateTime date;
      
      private Backend.Model.Accounts.Account account;
      
      /// <summary>
      /// Property for Backend.Model.Accounts.Account
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Backend.Model.Accounts.Account Account
      {
         get
         {
            return account;
         }
         set
         {
            if (this.account == null || !this.account.Equals(value))
            {
               if (this.account != null)
               {
                  Backend.Model.Accounts.Account oldAccount = this.account;
                  this.account = null;
                  oldAccount.RemoveComment(this);
               }
               if (value != null)
               {
                  this.account = value;
                  this.account.AddComment(this);
               }
            }
         }
      }
   
   }
}