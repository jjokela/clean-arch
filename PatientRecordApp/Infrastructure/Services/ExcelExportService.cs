﻿using PatientRecordApp.Application.Interfaces;
using PatientRecordApp.Domain.Entities;

namespace PatientRecordApp.Infrastructure.Services;

// the actual implementation of the excel export is in the Infrastructure
// this can access the entities in the 'deeper layers'
public class ExcelExportService : IExcelExportService
{
    public void Export(List<MedicalRecord> records, int riskScore)
    {
        foreach (var record in records)
        {
            Console.WriteLine(record);
        }

        Console.WriteLine($"Patient's risk score: {riskScore}");
    }
}