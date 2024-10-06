namespace PatientRecordApp.Trad.Application.Interfaces;

public interface IUseCase<TRequest, TResponse>
{
    TResponse Execute(TRequest request);
}