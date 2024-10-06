using Microsoft.Extensions.DependencyInjection;
using PatientRecordApp.Application.Interfaces;
using PatientRecordApp.Application.Services;
using PatientRecordApp.Domain.Interfaces;
using PatientRecordApp.Domain.Services;
using PatientRecordApp.Infrastructure.Repositories;
using PatientRecordApp.Infrastructure.Services;

var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection);

var serviceProvider = serviceCollection.BuildServiceProvider();
var medicalRecordService = serviceProvider.GetService<IMedicalRecordService>();


medicalRecordService!.ExportPatientRecordsToExcel(123);


void ConfigureServices(ServiceCollection services)
{
    services.AddTransient<IMedicalRecordRepository, MedicalRecordRepository>();
    services.AddTransient<IExcelExportService, ExcelExportService>();
    services.AddTransient<IMedicalRecordService, MedicalRecordService>();
    services.AddTransient<IRiskAssessmentService, RiskAssessmentService>();
}

Console.ReadLine();