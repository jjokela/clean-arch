using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;

public interface IBillingRepository
{
    void SaveBillingInfo(BillingInfo billingInfo);
}