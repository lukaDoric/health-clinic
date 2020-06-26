// File:    AppointmentSchedulingService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentSchedulingService

using Backend.Dto;
using Model.Accounts;
using Model.Hospital;
using Model.Util;
using Backend.Service.SchedulingService.SchedulingStrategies;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService
{
    public abstract class AppointmentSchedulingService
    {
        private List<Physitian> GetAvailablePhysitians()
        {
            throw new NotImplementedException();
        }

        private List<Room> GetAvailableRooms()
        {
            throw new NotImplementedException();
        }

        private List<TimeInterval> GetAvailableTimeIntervals(List<Physitian> physitians, List<Room> rooms)
        {
            throw new NotImplementedException();
        }

        private List<Physitian> FilterOutPhysitians(List<Physitian> physitians, List<TimeInterval> timeIntervals)
        {
            throw new NotImplementedException();
        }

        private List<Room> FilterOutRooms(List<Room> rooms, List<TimeInterval> timeIntervals)
        {
            throw new NotImplementedException();
        }

        private TimeInterval FindNearestTimeInterval(List<TimeInterval> potentialTimeIntervals)
        {
            throw new NotImplementedException();
        }

        private Physitian FindPhysitianByTimeInterval(List<Physitian> physitians, TimeInterval timeInterval)
        {
            throw new NotImplementedException();
        }

        private Room FindRoomByTimeInterval(List<Room> rooms, TimeInterval timeInterval)
        {
            throw new NotImplementedException();
        }

        private List<TimeInterval> TimeIntersectionAvailableAndSuggested(List<TimeInterval> availableTimeIntervals, List<TimeInterval> suggestedTimeInterval)
        {
            throw new NotImplementedException();
        }

        private SchedulingStrategy schedulingStrategyContext;
        private Backend.Dto.AppointmentDTO appointmentPreferences;

        public abstract AppointmentGeneralitiesDTO GetUpdatedAppointmentGeneralities();

        public abstract AppointmentDTO GetRecommendedAppointment();

        public void GetSuggestedAppointment(AppointmentDTO suggestedAppointment)
        {
            throw new NotImplementedException();
        }

        public SchedulingStrategy schedulingStrategy;
        public Backend.Repository.RoomRepository roomRepository;
        public Backend.Repository.PhysitianRepository physitianRepository;

    }
}