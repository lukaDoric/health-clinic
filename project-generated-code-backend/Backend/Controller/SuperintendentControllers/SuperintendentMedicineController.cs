using Model.Hospital;
using health_clinic_class_diagram.Backend.Service.MedicineService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Controller.SuperintendentControllers
{
    class SuperintendentMedicineController
    {
        private SuperintendentMedicineService superintendentMedicineService;
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
    }
}
