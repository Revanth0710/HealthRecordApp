using HealthRecordApp.Interfaces; // Brings in the IAccessible interface

namespace HealthRecordApp.Models {
    //Encapsulation	All doctor logic is contained in one class
    //SOLID – SRP	Only responsible for doctor-specific tasks
    
    public class Doctor : Person, IAccessible {
        // Implements the abstract method from Person
        public override void DisplayRole() 
        {
            Console.WriteLine($"Doctor: {Name}");
        }

        // Only Doctor has permission to write or add diagnoses  Role-based Authorization
        public void AddDiagnosis(HealthRecord record, string diagnosis) {
            record.Diagnosis = diagnosis;
        }

        //Required by IAccessible: Doctor can view the record
        //OOP – Polymorphism	ViewHealthRecord() behaves differently
        public void ViewHealthRecord(HealthRecord record) {
            Console.WriteLine($"[Doctor View] Diagnosis: {record.Diagnosis}");
        }
    }
}
