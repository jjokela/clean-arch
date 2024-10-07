using PatientRecordApp.Trad.Domain.Entities;

namespace PatientRecordApp.Trad.Application.Interfaces;

public interface ICalculateRiskScoreUseCase
{
    int Execute(Patient patient);
}