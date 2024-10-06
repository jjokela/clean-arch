namespace PatientRecordApp.Trad.Domain.Entities;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<MedicalRecord> MedicalRecords { get; set; } = [];
}