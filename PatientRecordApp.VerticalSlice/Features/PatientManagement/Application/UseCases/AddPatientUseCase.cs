using PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;
using PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;

namespace PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.UseCases;

public class AddPatientUseCase(IPatientRepository patientRepository) : IAddPatientUseCase
{
    public void Execute(Patient patient)
    {
        patientRepository.AddPatient(patient);
    }
}