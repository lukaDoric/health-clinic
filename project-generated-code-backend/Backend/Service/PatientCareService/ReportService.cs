using Backend.Repository;
using Model.Accounts;
using Model.MedicalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Service.PatientCareService
{
    class ReportService
    {
        private ReportRepository reportRepository;

        public ReportService()
        {
            this.reportRepository = new ReportFileSystem();
        }

        public List<Report> getReportsByPatient(Patient patient)
        {
            return reportRepository.GetReportsByPatient(patient);
        }

        public Report getLastReportByPatient(Patient patient)
        {
            List<Report> reports = reportRepository.GetReportsByPatient(patient);
            if(reports.Count > 0)
            {
                reports.Sort((a, b) => b.CompareTo(a));
                return reports[0];
            }
            return null;
        }

        public void newReport(Report report)
        {
            reportRepository.Save(report);
        }
    }
}
