using Backend.Dto;
using Backend.Model.Accounts;
using Backend.Model.Schedule;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinic_class_diagram.Backend.Service.SchedulingService
{
    class PatientScheduleService
    {
        private Patient loggedPatient;

        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Appointment NextAppointment()
        {
            throw new NotImplementedException();
        }

        public void NewAppointment(AppointmentDTO appointmentDTO)
        {
            throw new NotImplementedException();
        }

        public AppointmentRepository appointmentRepository;
    }
}
