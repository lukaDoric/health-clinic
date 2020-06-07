// File:    BlogPost.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class BlogPost

using System;

namespace Backend.Model.Blog
{
   public class BlogPost
   {
      private String name;
      
      private System.Collections.Generic.List<Comment> comment;
      
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
      private Backend.Model.Accounts.Physitian physitian;
      
      /// <summary>
      /// Property for Backend.Model.Accounts.Physitian
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Backend.Model.Accounts.Physitian Physitian
      {
         get
         {
            return physitian;
         }
         set
         {
            if (this.physitian == null || !this.physitian.Equals(value))
            {
               if (this.physitian != null)
               {
                  Backend.Model.Accounts.Physitian oldPhysitian = this.physitian;
                  this.physitian = null;
                  oldPhysitian.RemoveBlogPost(this);
               }
               if (value != null)
               {
                  this.physitian = value;
                  this.physitian.AddBlogPost(this);
               }
            }
         }
      }
   
   }
}