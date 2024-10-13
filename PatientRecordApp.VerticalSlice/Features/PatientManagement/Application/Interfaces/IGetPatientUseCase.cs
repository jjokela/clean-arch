using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.Interfaces;

public interface IGetPatientUseCase
{
    public Patient? Execute(int patientId);
}