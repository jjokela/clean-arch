using Moq;
using PatientRecordApp.VerticalSlice.Features.Billing.Application.UseCases;
using PatientRecordApp.VerticalSlice.Features.Billing.Domain.Services;
using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;
using PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Interfaces;

namespace PatientRecordApp.VerticalSlice.Test.Features.Billing.UseCases;

[TestFixture]
public class ProcessBillingUseCaseTests
{
    private Mock<IBillingRepository> _billingRepositoryMock;
    private Mock<INotificationService> _notificationServiceMock;
    private ProcessBillingUseCase _useCase;

    [SetUp]
    public void SetUp()
    {
        _billingRepositoryMock = new Mock<IBillingRepository>();
        _notificationServiceMock = new Mock<INotificationService>();

        _useCase = new ProcessBillingUseCase(
            _billingRepositoryMock.Object,
            new BillingService(),
            _notificationServiceMock.Object
            );
    }

    [Test]
    public void Execute_WithValidBillingInfo_SavesBillingInfo()
    {
        var billingInfo = new BillingInfo
        {
            PatientId = 123,
            Amount = 100
        };

        _useCase.Execute(billingInfo);

        var expectedAmount = 105;

        Assert.That(billingInfo.Amount, Is.EqualTo(expectedAmount));
        _billingRepositoryMock.Verify(r => r.SaveBillingInfo(billingInfo), Times.Once);
        _notificationServiceMock.Verify(n => n.SendNotification(
                $"Billing processed for Patient ID: {billingInfo.PatientId}, Amount: {billingInfo.Amount}"),
            Times.Once);
    }
}