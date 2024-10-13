using PatientRecordApp.VerticalSlice.Features.Billing.Domain.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Features.Billing.Domain.Services;

public class BillingService : IBillingService
{
    public decimal CalculateTotal(BillingInfo billingInfo)
    {
        return billingInfo.Amount * 1.05m;
    }
}