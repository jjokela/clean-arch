using PatientRecordApp.Trad.Application.Interfaces;
using PatientRecordApp.Trad.Domain.Entities;
using PatientRecordApp.Trad.Domain.Interfaces;

namespace PatientRecordApp.Trad.Application.UseCases;

public class GetPatientUseCase(IMedicalRecordRepository medicalRecordRepository) : IGetPatientUseCase
{
    public Patient? Execute(int patientId)
    {
        return medicalRecordRepository.GetPatientById(patientId);
    }
}