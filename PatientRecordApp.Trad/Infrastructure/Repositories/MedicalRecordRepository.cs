using PatientRecordApp.Trad.Domain.Entities;
using PatientRecordApp.Trad.Domain.Interfaces;

namespace PatientRecordApp.Trad.Infrastructure.Repositories;

public class MedicalRecordRepository : IMedicalRecordRepository
{
    public Patient GetPatientById(int patientId)
    {
        return new Patient
        {
            Id = patientId,
            DateOfBirth = DateTime.Now,
            Name = "Test Patient",
            MedicalRecords =
            [
                new MedicalRecord
                {
                    Id = 1,
                    Date = DateTime.Now,
                    Diagnosis = "High Risk Condition",
                    Treatment = "Paracetamol"
                }
            ]
        };
    }
}