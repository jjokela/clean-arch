using PatientRecordApp.Domain.Entities;
using PatientRecordApp.Domain.Interfaces;

namespace PatientRecordApp.Domain.Services;

public class RiskAssessmentService : IRiskAssessmentService
{
    public int CalculateRiskScore(Patient patient)
    {
        var riskScore = 0;
        foreach (var record in patient.MedicalRecords)
        {
            if (record.Diagnosis.Equals("High Risk Condition"))
            {
                riskScore += 10;
            }
        }

        return riskScore;
    }
}