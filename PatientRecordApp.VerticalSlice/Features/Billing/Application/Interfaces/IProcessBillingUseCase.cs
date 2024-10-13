using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Features.Billing.Application.Interfaces;

public interface IProcessBillingUseCase
{
    public void Execute(BillingInfo billingInfo);
}