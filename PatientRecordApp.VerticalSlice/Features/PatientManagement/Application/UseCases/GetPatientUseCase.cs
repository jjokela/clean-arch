using PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;
using PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;

namespace PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.UseCases;

public class GetPatientUseCase(IPatientRepository patientRepository) : IGetPatientUseCase
{
    public Patient? Execute(int patientId)
    {
        return patientRepository.GetPatientById(patientId);
    }
}