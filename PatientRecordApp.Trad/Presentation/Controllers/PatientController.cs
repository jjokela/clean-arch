using PatientRecordApp.Trad.Application.Interfaces;
using PatientRecordApp.Trad.Domain.Entities;
using PatientRecordApp.Trad.Presentation.Interfaces;

namespace PatientRecordApp.Trad.Presentation.Controllers;

public class PatientController(IGetPatientUseCase getPatientUseCase, 
    ICalculateRiskScoreUseCase calculateRiskScoreUseCase) : IPatientController
{
    public Patient? GetPatient(int patientId)
    {
        return getPatientUseCase.Execute(patientId);
    }

    public void DisplayPatientInformation(int patientId)
    {
        var patient = getPatientUseCase.Execute(patientId);

        if (patient is null)
        {
            Console.WriteLine("No patient found.");
        }
        else
        {
            var riskScore = calculateRiskScoreUseCase.Execute(patient);
            Console.WriteLine(patient);
            Console.WriteLine($"Risk score: {riskScore}");
        }
    }
}