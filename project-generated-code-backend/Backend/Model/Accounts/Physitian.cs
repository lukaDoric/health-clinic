// File:    Physitian.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Physitian

using Backend.Model.Blog;
using Backend.Model.MedicalExam;
using Backend.Model.Schedule;
using Backend.Model.Util;
using System;

namespace Backend.Model.Accounts
{
    public class Physitian : Account
    {
        private System.Collections.Generic.List<Specialization> specialization;

        public Physitian(string name, string surname, string id, DateTime dateOfBirth, string contact, Address address) : base(name, surname, id, dateOfBirth, contact, address)
        {
        }



        /// <summary>
        /// Property for collection of Specialization
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Specialization> Specialization
        {
            get
            {
                if (specialization == null)
                    specialization = new System.Collections.Generic.List<Specialization>();
                return specialization;
            }
            set
            {
                RemoveAllSpecialization();
                if (value != null)
                {
                    foreach (Specialization oSpecialization in value)
                        AddSpecialization(oSpecialization);
                }
            }
        }

        /// <summary>
        /// Add a new Specialization in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddSpecialization(Specialization newSpecialization)
        {
            if (newSpecialization == null)
                return;
            if (this.specialization == null)
                this.specialization = new System.Collections.Generic.List<Specialization>();
            if (!this.specialization.Contains(newSpecialization))
                this.specialization.Add(newSpecialization);
        }

        /// <summary>
        /// Remove an existing Specialization from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveSpecialization(Specialization oldSpecialization)
        {
            if (oldSpecialization == null)
                return;
            if (this.specialization != null)
                if (this.specialization.Contains(oldSpecialization))
                    this.specialization.Remove(oldSpecialization);
        }

        /// <summary>
        /// Remove all instances of Specialization from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllSpecialization()
        {
            if (specialization != null)
                specialization.Clear();
        }
        private Backend.Model.Util.TimeInterval workSchedule;
        private System.Collections.Generic.List<TimeInterval> vacationTime;

        /// <summary>
        /// Property for collection of Backend.Model.Util.TimeInterval
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<TimeInterval> VacationTime
        {
            get
            {
                if (vacationTime == null)
                    vacationTime = new System.Collections.Generic.List<TimeInterval>();
                return vacationTime;
            }
            set
            {
                RemoveAllVacationTime();
                if (value != null)
                {
                    foreach (Backend.Model.Util.TimeInterval oTimeInterval in value)
                        AddVacationTime(oTimeInterval);
                }
            }
        }

        /// <summary>
        /// Add a new Backend.Model.Util.TimeInterval in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddVacationTime(Backend.Model.Util.TimeInterval newTimeInterval)
        {
            if (newTimeInterval == null)
                return;
            if (this.vacationTime == null)
                this.vacationTime = new System.Collections.Generic.List<TimeInterval>();
            if (!this.vacationTime.Contains(newTimeInterval))
                this.vacationTime.Add(newTimeInterval);
        }

        /// <summary>
        /// Remove an existing Backend.Model.Util.TimeInterval from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveVacationTime(Backend.Model.Util.TimeInterval oldTimeInterval)
        {
            if (oldTimeInterval == null)
                return;
            if (this.vacationTime != null)
                if (this.vacationTime.Contains(oldTimeInterval))
                    this.vacationTime.Remove(oldTimeInterval);
        }

        /// <summary>
        /// Remove all instances of Backend.Model.Util.TimeInterval from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllVacationTime()
        {
            if (vacationTime != null)
                vacationTime.Clear();
        }
        private System.Collections.Generic.List<BlogPost> blogPost;

        /// <summary>
        /// Property for collection of BlogPost
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<BlogPost> BlogPost
        {
            get
            {
                if (blogPost == null)
                    blogPost = new System.Collections.Generic.List<BlogPost>();
                return blogPost;
            }
            set
            {
                RemoveAllBlogPost();
                if (value != null)
                {
                    foreach (BlogPost oBlogPost in value)
                        AddBlogPost(oBlogPost);
                }
            }
        }

        /// <summary>
        /// Add a new BlogPost in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddBlogPost(BlogPost newBlogPost)
        {
            if (newBlogPost == null)
                return;
            if (this.blogPost == null)
                this.blogPost = new System.Collections.Generic.List<BlogPost>();
            if (!this.blogPost.Contains(newBlogPost))
            {
                this.blogPost.Add(newBlogPost);
                newBlogPost.Physitian = this;
            }
        }

        /// <summary>
        /// Remove an existing BlogPost from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveBlogPost(BlogPost oldBlogPost)
        {
            if (oldBlogPost == null)
                return;
            if (this.blogPost != null)
                if (this.blogPost.Contains(oldBlogPost))
                {
                    this.blogPost.Remove(oldBlogPost);
                    oldBlogPost.Physitian = null;
                }
        }

        /// <summary>
        /// Remove all instances of BlogPost from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllBlogPost()
        {
            if (blogPost != null)
            {
                System.Collections.ArrayList tmpBlogPost = new System.Collections.ArrayList();
                foreach (BlogPost oldBlogPost in blogPost)
                    tmpBlogPost.Add(oldBlogPost);
                blogPost.Clear();
                foreach (BlogPost oldBlogPost in tmpBlogPost)
                    oldBlogPost.Physitian = null;
                tmpBlogPost.Clear();
            }
        }
        private Appointment[] appointment;
        private Report[] report;
        private SpecialistReferral[] specialistReferral;
        private FollowUp[] followUp;
        private InpatientCare[] inpatientCare;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}