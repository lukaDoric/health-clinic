// File:    BlogPost.cs
// Author:  Luka Doric
// Created: Friday, May 15, 2020 23:46:22
// Purpose: Definition of Class BlogPost

using Model.Accounts;
using System;
using System.Collections.Generic;

namespace Model.Blog
{
   public class BlogPost
   {
      private String name;
      
      private List<Comment> comment;
      
      /// <summary>
      /// Property for collection of Comment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public List<Comment> Comment
      {
         get
         {
            if (comment == null)
               comment = new List<Comment>();
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
            this.comment.Add(newComment);
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
               this.comment.Remove(oldComment);
      }
      
      /// <summary>
      /// Remove all instances of Comment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllComment()
      {
         if (comment != null)
            comment.Clear();
      }
      private Model.Accounts.Physitian physitian;
      
      /// <summary>
      /// Property for Model.Accounts.Physitian
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Physitian Physitian
      {
         get
         {
            return physitian;
         }
         set
         {
            this.physitian = value;
         }
      }
   
   }
}