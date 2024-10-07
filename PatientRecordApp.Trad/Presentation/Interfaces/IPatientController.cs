using PatientRecordApp.Trad.Domain.Entities;

namespace PatientRecordApp.Trad.Presentation.Interfaces
{
    public interface IPatientController
    {
        public Patient? GetPatient(int patientId);
        public void DisplayPatientInformation(int patientId);
    }
}
