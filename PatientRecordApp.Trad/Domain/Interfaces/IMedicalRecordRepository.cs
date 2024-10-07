using PatientRecordApp.Trad.Domain.Entities;

namespace PatientRecordApp.Trad.Domain.Interfaces;

public interface IMedicalRecordRepository
{
    public Patient? GetPatientById(int patientId);
}