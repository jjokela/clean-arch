using PatientRecordApp.Domain.Entities;

namespace PatientRecordApp.Domain.Interfaces;

public interface IRiskAssessmentService
{
    public int CalculateRiskScore(Patient patient);
}