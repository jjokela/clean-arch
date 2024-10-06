using PatientRecordApp.Application.Interfaces;
using PatientRecordApp.Domain.Interfaces;

namespace PatientRecordApp.Application.Services;

public class MedicalRecordService(
    IMedicalRecordRepository medicalRecordRepository,
    IExcelExportService excelExportService,
    IRiskAssessmentService riskAssessmentService)
    : IMedicalRecordService
{
    public void ExportPatientRecordsToExcel(int patientId)
    {
        var patient = medicalRecordRepository.GetPatientById(patientId);

        if (patient is null)
        {
            throw new Exception($"Patient with id {patientId} not found");
        }

        var records = patient.MedicalRecords;
        var riskScore = riskAssessmentService.CalculateRiskScore(patient);

        excelExportService.Export(records, riskScore);
    }
}