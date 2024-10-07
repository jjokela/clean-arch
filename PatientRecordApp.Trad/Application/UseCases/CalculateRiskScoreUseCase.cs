using PatientRecordApp.Trad.Application.Interfaces;
using PatientRecordApp.Trad.Domain.Entities;
using PatientRecordApp.Trad.Domain.Interfaces;

namespace PatientRecordApp.Trad.Application.UseCases;

public class CalculateRiskScoreUseCase(IRiskAssessmentService riskAssessmentService) : ICalculateRiskScoreUseCase
{
    public int Execute(Patient patient)
    {
        if (patient is null)
        {
            throw new ArgumentException("No patient found");
        }

        return riskAssessmentService.CalculateRiskScore(patient);
    }
}