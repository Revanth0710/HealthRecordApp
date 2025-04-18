# 🩺 HealthRecordApp (.NET 9)

A modular, role-based **health record management system** built using **C# and .NET 9**, showcasing clean architecture, OOP principles, and **Dependency Injection (DI)**.

---

## 🧠 Core Features

- 👨‍⚕️ **Doctors** can add and view diagnoses.
- 🧑‍🦱 **Patients** can only view diagnoses.
- ✅ Clean separation of roles using **OOP**.
- 📦 Built with **Dependency Injection** for flexibility and testability.

---

## 📚 OOP Concepts Used

| Concept                | Where It's Used                   |
|------------------------|-----------------------------------|
| **Abstraction**        | `Person` class (abstract)         |
| **Inheritance**        | `Doctor`, `Patient` → `Person`    |
| **Polymorphism**       | `ViewHealthRecord()` variations   |
| **Interfaces**         | `IAccessible`                     |
| **Encapsulation**      | Role-based logic per class        |
| **Dependency Injection** | `HealthRecordService` constructor |

---

## 🧱 Architecture Overview

```plaintext
                 [Abstract Class]
                     Person
                        ▲
         ┌──────────────┼──────────────┐
         │                             │
     [Doctor]                    [Patient]
         │                             │
    Implements                    Implements
     IAccessible                  IAccessible
         │                             │
         └──────────► HealthRecordService ◄──────────
                               │
                     Uses HealthRecord


📌 Sample Output

Doctor: Dr. Revanth
Patient: Alex
[Doctor View] Diagnosis: Seasonal Fever
[Patient View] Diagnosis: Seasonal Fever


🏥 Real-World Use Case

Simulates a simplified hospital backend system where:
Doctors can update records.
Patients can securely view their data.
Roles are enforced via interfaces and OOP patterns.



