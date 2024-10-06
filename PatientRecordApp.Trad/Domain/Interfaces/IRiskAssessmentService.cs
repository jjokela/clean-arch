using PatientRecordApp.Trad.Domain.Entities;

namespace PatientRecordApp.Trad.Domain.Interfaces;

public interface IRiskAssessmentService
{
    public int CalculateRiskScore(Patient patient);
}