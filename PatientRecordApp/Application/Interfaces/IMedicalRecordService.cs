namespace PatientRecordApp.Application.Interfaces;

public interface IMedicalRecordService
{
    public void ExportPatientRecordsToExcel(int patientId);
}