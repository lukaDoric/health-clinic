using Model.Accounts;
using Model.Hospital;
using health_clinic_class_diagram.Backend.Service.MedicineService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Dto;

namespace Backend.Controller.PhysitianControllers
{
    class PhysitianMedicineController
    {
        private Physitian loggedPhysitian;
        private PhysitianMedicineService physitianMedicineService;

        public PhysitianMedicineController()
        {
            this.physitianMedicineService = new PhysitianMedicineService();
        }

        public List<Medicine> getAllFromWaitingList()
        {
            //TODO: Medicine
            return new List<Medicine>();
        }
        public List<Medicine> getAllApproved()
        {
            //TODO: Medicine
            return new List<Medicine>();
        }
        public void Approve(Medicine medicine)
        {
            throw new NotImplementedException();
        }
        public void Reject(RejectedMedicineDTO rejection)
        {
            throw new NotImplementedException();
        }
    }
}
