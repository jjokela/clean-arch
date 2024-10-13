using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.Interfaces;

public interface IAddPatientUseCase
{
    public void Execute(Patient patient);
}