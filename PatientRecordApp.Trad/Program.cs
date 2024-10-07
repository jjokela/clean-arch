using Microsoft.Extensions.DependencyInjection;
using PatientRecordApp.Trad.Application.Interfaces;
using PatientRecordApp.Trad.Application.UseCases;
using PatientRecordApp.Trad.Domain.Interfaces;
using PatientRecordApp.Trad.Domain.Services;
using PatientRecordApp.Trad.Infrastructure.Repositories;
using PatientRecordApp.Trad.Infrastructure.Services;
using PatientRecordApp.Trad.Presentation.Controllers;
using PatientRecordApp.Trad.Presentation.Interfaces;

var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection);

var serviceProvider = serviceCollection.BuildServiceProvider();
var controller = serviceProvider.GetService<IPatientController>();

controller!.DisplayPatientInformation(123);

void ConfigureServices(ServiceCollection services)
{
    services.AddTransient<IMedicalRecordRepository, MedicalRecordRepository>();
    services.AddTransient<IExcelExportService, ExcelExportService>();
    services.AddTransient<IRiskAssessmentService, RiskAssessmentService>();
    services.AddTransient<IRiskAssessmentService, RiskAssessmentService>();
    services.AddTransient<IGetPatientUseCase, GetPatientUseCase>();
    services.AddTransient<ICalculateRiskScoreUseCase, CalculateRiskScoreUseCase>();
    services.AddTransient<IPatientController, PatientController>();
}

Console.ReadLine();