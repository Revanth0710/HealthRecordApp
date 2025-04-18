namespace HealthRecordApp.Models {
    public class HealthRecord {
        //SRP (Single Responsibility)	This class only holds diagnosis data — no logic
        public string? Diagnosis { get; set; }
        //Store a diagnosis text
    }
}
