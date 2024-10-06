using PatientRecordApp.Trad.Domain.Entities;
using PatientRecordApp.Trad.Domain.Enums;
using PatientRecordApp.Trad.Domain.Interfaces;

namespace PatientRecordApp.Trad.Domain.Services;

public class RiskAssessmentService : IRiskAssessmentService
{
    public int CalculateRiskScore(Patient patient)
    {
        var riskScore = 0;
        foreach (var record in patient.MedicalRecords)
        {
            riskScore += record.DiagnosisType switch
            {
                DiagnosisType.LowRisk => 0,
                DiagnosisType.MediumRisk => 5,
                DiagnosisType.HighRisk => 10,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        return riskScore;
    }
}