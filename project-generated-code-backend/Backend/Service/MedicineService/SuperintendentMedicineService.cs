using Model.Hospital;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinic_class_diagram.Backend.Service.MedicineService
{
    class SuperintendentMedicineService
    {
        private RejectionRepository rejectionRepository;
        private WaitingMedicineRepository waitingRepostitory;
        private ApprovedMedicineRepository approvedRepository;

        public List<Medicine> getAllApproved()
        {
            throw new NotImplementedException();
        }

        public List<Rejection> getAllRejected()
        {
            throw new NotImplementedException();
        }

        public List<Medicine> getAllWaiting()
        {
            throw new NotImplementedException();
        }

        //TODO: Dodati metode za getovanje pojedinacnih i brisanje ako treba
    }
}
