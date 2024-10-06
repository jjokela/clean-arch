using PatientRecordApp.Trad.Domain.Entities;

namespace PatientRecordApp.Trad.Application.Interfaces;

// the interface for excel export is in the Application layer
// the implementation of it is in Infrastructure layer
// Application layer coordinates between Domain and Infrastructure layers
public interface IExcelExportService
{
    public void Export(List<MedicalRecord> records, int riskScore);
}