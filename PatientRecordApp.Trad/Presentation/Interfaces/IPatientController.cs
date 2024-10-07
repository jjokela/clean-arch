using PatientRecordApp.Trad.Domain.Entities;

namespace PatientRecordApp.Trad.Presentation.Interfaces
{
    public interface IPatientController
    {
        public Patient GetPatient(int patientId);
    }
}
