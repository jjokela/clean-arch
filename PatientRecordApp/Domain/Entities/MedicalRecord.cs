namespace PatientRecordApp.Domain.Entities;

public class MedicalRecord
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} Date: {Date} Diagnosis: {Diagnosis} Treatment: {Treatment}";
    }
}