using PatientRecordApp.VerticalSlice.Features.Billing.Domain.Services;
using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;

namespace PatientRecordApp.VerticalSlice.Test.Features.Billing.Domain.Services;

[TestFixture]
public class BillingServiceTests
{
    [Test]
    public void CalculateTotal_WithPositiveAmount_ReturnsBillableAmount()
    {
        var billingService = new BillingService();
        var billingInfo = new BillingInfo { PatientId = 123, Amount = 100 };

        var expected = 105;
        var result = billingService.CalculateTotal(billingInfo);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CalculateTotal_WithZeroAmount_ReturnsZeroAmount()
    {
        var billingService = new BillingService();
        var billingInfo = new BillingInfo { PatientId = 123, Amount = 0 };

        var expected = 0;
        var result = billingService.CalculateTotal(billingInfo);

        Assert.That(result, Is.EqualTo(expected));
    }
}