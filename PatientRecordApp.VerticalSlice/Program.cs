using Microsoft.Extensions.DependencyInjection;
using PatientRecordApp.VerticalSlice.Features.Billing.Application.Interfaces;
using PatientRecordApp.VerticalSlice.Features.Billing.Application.UseCases;
using PatientRecordApp.VerticalSlice.Features.Billing.Domain.Interfaces;
using PatientRecordApp.VerticalSlice.Features.Billing.Domain.Services;
using PatientRecordApp.VerticalSlice.Features.Billing.Infrastructure.Repositories;
using PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.Interfaces;
using PatientRecordApp.VerticalSlice.Features.PatientManagement.Application.UseCases;
using PatientRecordApp.VerticalSlice.Features.PatientManagement.Infrastructure.Repositories;
using PatientRecordApp.VerticalSlice.Shared.Domain.Entities;
using PatientRecordApp.VerticalSlice.Shared.Domain.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Interfaces;
using PatientRecordApp.VerticalSlice.Shared.Services;

var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection);

var serviceProvider = serviceCollection.BuildServiceProvider();

var newPatient = new Patient { Id = 123, Name = "John Doe" };
var addPatientUseCase = serviceProvider.GetService<IAddPatientUseCase>();
addPatientUseCase!.Execute(newPatient);
Console.WriteLine($"Patient {newPatient.Name} added successfully.");

var getPatientUseCase = serviceProvider.GetService<IGetPatientUseCase>();
var retrievedPatient = getPatientUseCase!.Execute(newPatient.Id);
Console.WriteLine($"Retrieved Patient: {retrievedPatient!.Name}");

var billingInfo = new BillingInfo
{
    PatientId = retrievedPatient!.Id,
    Amount = 100.00m
};

var processBillingUseCase = serviceProvider.GetService<IProcessBillingUseCase>();
processBillingUseCase!.Execute(billingInfo);

Console.WriteLine("Press enter to exit...");


void ConfigureServices(ServiceCollection services)
{
    services.AddScoped<IBillingRepository, BillingRepository>();
    services.AddScoped<IPatientRepository, PatientRepository>();
    services.AddScoped<INotificationService, NotificationService>();

    // Billing
    services.AddTransient<IProcessBillingUseCase, ProcessBillingUseCase>();
    services.AddTransient<IBillingService, BillingService>();

    // PatientManagement
    services.AddTransient<IAddPatientUseCase, AddPatientUseCase>();
    services.AddTransient<IGetPatientUseCase, GetPatientUseCase>();
}
