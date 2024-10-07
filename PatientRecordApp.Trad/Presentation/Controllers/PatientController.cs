using PatientRecordApp.Trad.Application.Interfaces;
using PatientRecordApp.Trad.Domain.Entities;
using PatientRecordApp.Trad.Presentation.Interfaces;

namespace PatientRecordApp.Trad.Presentation.Controllers;

public class PatientController(IGetPatientUseCase getPatientUseCase) : IPatientController
{
    public Patient GetPatient(int patientId)
    {
        return getPatientUseCase.Execute(patientId);
    }
}