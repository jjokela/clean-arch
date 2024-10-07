using PatientRecordApp.Trad.Domain.Entities;

namespace PatientRecordApp.Trad.Application.Interfaces;

public interface IGetPatientUseCase
{
    Patient Execute(int patientId);
}