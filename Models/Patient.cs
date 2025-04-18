using HealthRecordApp.Interfaces;

namespace HealthRecordApp.Models {
    public class Patient : Person, IAccessible {
        //Implements DisplayRole() from abstract base
        public override void DisplayRole() => Console.WriteLine($"Patient: {Name}");
        
        //Interface Implementation
        public void ViewHealthRecord(HealthRecord record) {
            Console.WriteLine($"[Patient View] Diagnosis: {record.Diagnosis}");
        }
    }
}
