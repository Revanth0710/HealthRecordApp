namespace HealthRecordApp.Models {
    public abstract class Person {
        public string? Name { get; set; }
        public abstract void DisplayRole(); // Forces subclasses to implement their own role display
    }
}
//An abstract class:
//Cannot be instantiated directly (you can’t say new Person())
//Can contain both defined and undefined methods
//Forces any child class to implement certain behaviors

