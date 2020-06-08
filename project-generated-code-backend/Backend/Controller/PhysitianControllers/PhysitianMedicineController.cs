using Backend.Model.Accounts;
using Backend.Model.Hospital;
using health_clinic_class_diagram.Backend.Service.MedicineService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Controller.PhysitianControllers
{
    class PhysitianMedicineController
    {
        private Physitian loggedPhysitian;
        private PhysitianMedicineService physitianMedicineService;

        public Medicine getFromWaitingList(Medicine medicine)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> getAllFromWaitingList()
        {
            throw new NotImplementedException();
        }

        public Medicine getApproved(Medicine medicine)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> getAllApproved()
        {
            throw new NotImplementedException();
        }
    }
}
