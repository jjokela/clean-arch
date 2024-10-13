using PatientRecordApp.VerticalSlice.Features.Billing.Application.Interfaces;
using PatientRecordApp.VerticalSlice.Features.Billing.Domain.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;
using PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Interfaces;

namespace PatientRecordApp.VerticalSlice.Features.Billing.Application.UseCases;

public class ProcessBillingUseCase(
    IBillingRepository billingRepository,
    IBillingService billingService,
    INotificationService notificationService)
    : IProcessBillingUseCase
{
    public void Execute(BillingInfo billingInfo)
    {
        var totalAmount = billingService.CalculateTotal(billingInfo);
        billingInfo.Amount = totalAmount;
        billingRepository.SaveBillingInfo(billingInfo);
        notificationService.SendNotification(
            $"Billing processed for Patient ID: {billingInfo.PatientId}, Amount: {billingInfo.Amount}");
    }
}