using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;
using PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;

namespace PatientRecordApp.VerticalSlice.Features.PatientManagement.Infrastructure.Repositories;

public class PatientRepository : IPatientRepository
{
    private static readonly Dictionary<int, Patient> Patients = new();

    public void AddPatient(Patient patient)
    {
        Patients.Add(patient.Id, patient);
    }

    public Patient? GetPatientById(int patientId)
    {
        Patients.TryGetValue(patientId, out var patient);
        return patient;
    }
}