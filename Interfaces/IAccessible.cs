using HealthRecordApp.Models;

namespace HealthRecordApp.Interfaces {
    public interface IAccessible {
        void ViewHealthRecord(HealthRecord record);
    }
}
//This enforces polymorphism and decouples access logic from roles.
//You can inject any class that implements this.