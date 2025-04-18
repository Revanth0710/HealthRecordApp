using HealthRecordApp.Models;
using HealthRecordApp.Interfaces;

namespace HealthRecordApp.Services {
    public class HealthRecordService {
        private readonly IAccessible _user;

        // Dependency Injection
        public HealthRecordService(IAccessible user) {
            _user = user; // Injected user: could be Doctor or Patient
        }

        public void ShowRecord(HealthRecord record) {
            _user.ViewHealthRecord(record); // Executes the correct method based on user type
        }
    }
}
//Accepts any IAccessible-type user (Doctor or Patient)
//Calls ViewHealthRecord() method dynamically
//You can inject different roles into this same class — this is true DI
//Keeps your code flexible and testable.
//You can reuse the service for any type of user now or in the future.

