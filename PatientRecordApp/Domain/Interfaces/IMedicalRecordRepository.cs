using PatientRecordApp.Domain.Entities;

namespace PatientRecordApp.Domain.Interfaces;

public interface IMedicalRecordRepository
{
    public Patient GetPatientById(int patientId);
}