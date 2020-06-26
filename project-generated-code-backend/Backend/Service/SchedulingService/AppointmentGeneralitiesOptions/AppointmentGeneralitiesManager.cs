using Backend.Dto;
using Backend.Repository;
using Model.Accounts;
using Model.Hospital;
using Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Service.SchedulingService.AppointmentGeneralitiesOptions
{
    class AppointmentGeneralitiesManager
    {
        private AppointmentDTO appointmentPreferrences;
        private PhysitianRepository physitianRepository;
        private RoomRepository roomRepository;
        private List<TimeInterval> timeIntervals;
        private List<Physitian> physitians;
        private List<Room> rooms;
        public AppointmentGeneralitiesManager()
        {
            this.physitianRepository = new PhysitianFileSystem();
            this.roomRepository = new RoomFileSystem();
        }

        public AppointmentGeneralitiesDTO getAppointmentGeneralities(AppointmentDTO appointmentPreferrences)
        {
            this.appointmentPreferrences = appointmentPreferrences;
            rooms = GetAllRooms();
            physitians = GetAllPhysitians();
            timeIntervals = GetAvailableTimeIntervals();
            AppointmentGeneralitiesDTO updatedGeneralities = new AppointmentGeneralitiesDTO();
            updatedGeneralities.AvailableTimeIntervals = timeIntervals;
            updatedGeneralities.AvailablePhysitians = GetAvailablePhysitians();
            updatedGeneralities.AvailableRooms = GetAvailableRooms();
            return updatedGeneralities;
        }
        private List<TimeInterval> GetAvailableTimeIntervals()
        {
            List<TimeInterval> availableTimeIntervals = new List<TimeInterval>();
            foreach (TimeInterval timeInterval in GetAllTimeIntervals())
            {
                if (IsTimeIntervalAvailable(timeInterval))
                {
                    availableTimeIntervals.Add(timeInterval);
                }
            }
            return availableTimeIntervals;
        }
        private List<Physitian> GetAvailablePhysitians()
        {
            List<Physitian> availablePhysitians = new List<Physitian>();
            PhysitianAvailabilityService physitianAvailability = new PhysitianAvailabilityService();
            foreach (Physitian physitian in physitians)
            {
                if (physitianAvailability.IsPhysitianAvailableAtAnyTime(physitian, timeIntervals))
                {
                    availablePhysitians.Add(physitian);
                }
            }
            return availablePhysitians;
        }
        private List<Room> GetAvailableRooms()
        {
            List<Room> availableRooms = new List<Room>();
            RoomAvailabilityService roomAvailability = new RoomAvailabilityService();
            foreach (Room room in rooms)
            {
                if (roomAvailability.IsRoomAvailableAtAnyTime(room, timeIntervals))
                {
                    availableRooms.Add(room);
                }
            }
            return availableRooms;
        }
        private List<Physitian> GetAllPhysitians()
        {
            List<Physitian> allPhysitians = new List<Physitian>();
            if (appointmentPreferrences.IsPreferedPhysitianSelected())
            {
                allPhysitians.Add(appointmentPreferrences.Physitian);
            }
            else
            {
                allPhysitians = physitianRepository.GetPhysitiansByProcedureType(appointmentPreferrences.ProcedureType);
            }
            return allPhysitians;
        }
        private List<Room> GetAllRooms()
        {
            List<Room> allRooms = new List<Room>();
            if (appointmentPreferrences.IsPreferedRoomSelected())
            {
                allRooms.Add(appointmentPreferrences.Room);
            }
            else
            {
                allRooms = roomRepository.GetRoomsByProcedureType(appointmentPreferrences.ProcedureType);
            }
            return allRooms;
        }
        private List<TimeInterval> GetAllTimeIntervals()
        {
            TimeIntervalGenerator generator = new TimeIntervalGenerator(appointmentPreferrences.ProcedureType, appointmentPreferrences.RestrictedHours);
            List<TimeInterval> allTimeIntervals = generator.getTimeIntervals();
            TimeIntervalFilter filter = new TimeIntervalFilter();
            if (appointmentPreferrences.IsPreferredDateSelected())
            {
                allTimeIntervals = filter.flterByDate(allTimeIntervals, appointmentPreferrences.Date);
            }
            if (appointmentPreferrences.IsPreferredTimeSelected())
            {
                allTimeIntervals = filter.flterByTime(allTimeIntervals, appointmentPreferrences.Time);
            }
            return allTimeIntervals;
        }
        private bool IsTimeIntervalAvailable(TimeInterval timeInterval)
        {
            PatientAvailabilityService patientAvailability = new PatientAvailabilityService();
            bool isPatientAvailable = patientAvailability.IsPatientAvailable(appointmentPreferrences.Patient, timeInterval);
            PhysitianAvailabilityService physitianAvailability = new PhysitianAvailabilityService();
            bool isAnyPhysitianAvailable = physitianAvailability.IsAnyPhysitianAvailable(physitians, timeInterval);
            RoomAvailabilityService roomAvailability = new RoomAvailabilityService();
            bool isAnyRoomAvailable = roomAvailability.IsAnyRoomAvailable(rooms, timeInterval);
            return isPatientAvailable && isAnyPhysitianAvailable && isAnyRoomAvailable;
        }
    }
}
