using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;
using PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;

namespace PatientRecordApp.VerticalSlice.Features.Billing.Infrastructure.Repositories;

public class BillingRepository : IBillingRepository
{
    private static readonly List<BillingInfo> BillingRecords = [];

    public IEnumerable<BillingInfo> GetBillingRecords()
    {
        return BillingRecords;
    }

    public void SaveBillingInfo(BillingInfo billingInfo)
    {
        BillingRecords.Add(billingInfo);
    }
}