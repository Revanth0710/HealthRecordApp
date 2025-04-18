using HealthRecordApp.Models;
using HealthRecordApp.Services;

class Program {
    static void Main(string[] args) {
        // Create doctor and patient
        Doctor doctor = new Doctor { Name = "Dr. Revanth" };
        Patient patient = new Patient { Name = "Alex" };

        // Show their roles
        doctor.DisplayRole();
        patient.DisplayRole();

        // Create a health record and assign diagnosis
        HealthRecord record = new HealthRecord();
        doctor.AddDiagnosis(record, "Seasonal Fever");

        // Inject into services
        var doctorService = new HealthRecordService(doctor);
        doctorService.ShowRecord(record);

        var patientService = new HealthRecordService(patient);
        patientService.ShowRecord(record);
    }
}
