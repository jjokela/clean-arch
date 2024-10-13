using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;

public interface IPatientRepository
{
    void AddPatient(Patient patient);
    Patient? GetPatientById(int patientId);
}