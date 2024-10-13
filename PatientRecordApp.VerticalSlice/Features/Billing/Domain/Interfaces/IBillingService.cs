using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Features.Billing.Domain.Interfaces;

public interface IBillingService
{
    public decimal CalculateTotal(BillingInfo billingInfo);
}