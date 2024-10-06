using PatientRecordApp.Trad.Domain.Enums;

namespace PatientRecordApp.Trad.Domain.Entities;

public class MedicalRecord
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }
    public DiagnosisType DiagnosisType { get; set; }
    public override string ToString()
    {
        return $"Id: {Id} Date: {Date} Diagnosis: {Diagnosis} Treatment: {Treatment}";
    }
}