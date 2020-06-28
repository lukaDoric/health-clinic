using Backend.Repository;
using Model.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinic_class_diagram.Backend.Service.HospitalAccountsService
{
    public class PatientAccountsService
    {
        private PatientRepository patientRepository;
        private AppointmentRepository appointmentRepository;
        private ReportRepository reportRepository;

        public PatientAccountsService()
        {
            this.patientRepository = new PatientFileSystem();
            this.appointmentRepository = new AppointmentFileSystem();
            this.reportRepository = new ReportFileSystem();
        }

        public List<Patient> getAllPatients()
        {
            return patientRepository.GetAll();
        }
        public List<Patient> getPatientsForPhysitian(Physitian physitian)
        {
            //TODO: naci pacijente koji su ili zakazani u buducnosti ili imaju neki report kod zadatog lekara
            return patientRepository.GetAll();
        }
    }
}
