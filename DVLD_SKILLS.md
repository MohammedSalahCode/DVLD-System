# DVLD Project – Skills and Learnings

This document tracks skills gained almost daily during the development of the DVLD System, providing practical experience in OOP, design decisions, and feature implementation.

## Design & Architecture

- **[2025-10-25]** – Implemented a **3-Tier Architecture** (Data Access, Business Logic, UI) to separate concerns and improve maintainability.
- **[2025-11-08]** – Built reusable **User Controls** (e.g., `ctrlPersonCardWithFilter.cs`) to reduce duplication and simplify UI maintenance.
- **[2025-11-12]** – Applied **forward-thinking design** by adding extensible methods (e.g., `AddNewTestType()`).
- **[2025-12-11]** – Organized features (e.g., `License Renewal`) by placing business logic in the Business Layer and keeping UI focused on user interaction.
- **[2025-12-15]** – Encapsulated **detain/release license features** in `clsLicense` class (instead of `clsDetainedLicense`):  
  - Kept domain logic in the License object.  
  - Exposed high-level UI functionality (**abstraction**) while hiding internal coordination with `clsDetainedLicense` and `clsApplication` classes.

## C# & OOP

- **[2025-11-01]** – Used **factory-style methods** (e.g., `Find()`) with private constructors to safely create objects from saved  data.
- **[2025-11-08]** – Applied **Composition** by including a `clsPerson` object inside `clsUser` to access and manage person details directly for each user.
- **[2025-11-10]** – Used **static classes** (all members static, cannot create objects, e.g., `clsGlobal`) to store global data like the current user:  
  - Understood the difference from **regular classes with static methods** (can create objects, but some methods are static for utility purposes).
- **[2025-11-12]** Learned to use **enums** to reduce errors and improve code readability.
- **[2025-11-16]** – Applied **Inheritance** by creating `clsLocalDrivingLicenseApplication` that inherits from `clsApplication`, reusing common properties and methods to reduce duplication.
- **[2025-12-01]** – Learned how to initialize **parent** properties in **child classes**:  
  - Using `:base(...)` when the parent has logic.  
  - Or directly in the child constructor for simple data-only parents.
- **[2025-12-04]** – Learned that C# reference types behave similarly to C++ pointers:  
  - Both refer to memory locations.  
  - Helped understand why uninitialized objects cause null-reference issues.
- **[2025-12-04]** – Improved handling of **multi-output DAL functions** using `ref` parameters:  
  - Retrieve multiple SQL fields in one call.  
  - Map SQL types (tinyint, smallint, etc.) to C# enums for cleaner and safer object initialization.
- **[2025-12-11]** – Improved understanding of **C# reference types** after fixing a shared-state bug:  
  - Assigning one object to another (e.g., `_NewLicense = _SelectedLicenseInfo`) copied the reference instead of creating a new instance.  
  - Learned to create new instances to avoid shared-state issues and improve OOP practices.
- **[2025-12-13]** – Learned how to use **nested types in C#** by defining enums (`enMode`, `enIssueReason`) inside the `clsLicense` class:  
  - Accessed them via `using static`.  
  - Improved code organization and readability across UI and business layers.
- **[Throughout the project]** – Defined static methods in the **Data Access Layer** and called them from the Business Layer to handle CRUD operations.
- **[Throughout the project]** – Worked extensively with **ADO.NET** to manage data access across multiple entities.
- **[Throughout the project]** – Practiced **User Controls**, exposing properties, sending data between forms, and handling events using delegates, which helped during project implementation.

## Database, SQL & Data Integrity

- **[2025-11-16]** – Improved skills in understanding and fixing database constraint errors (e.g., Foreign Key issues), ensuring data consistency.
- **[2025-11-16]** – Handled **basic type mismatches** between C# and SQL Server (e.g., tinyint → byte, smallmoney → decimal) for safer data mapping.
- **[Throughout the project]** – Developed **multi-table SQL queries** with JOINs, subqueries, computed fields (e.g., `FullName`), CASE statements for conditional logic, COUNT aggregation, and NULL handling:  
  - Retrieve and validate data according to business rules.  
  - Display results in the UI.
- **[2025-11-18]** – Improved understanding of **data integrity and constraints**, ensuring relationships between tables (e.g., `Applications` and `LocalDrivingLicenseApplications`) remain consistent.
- **[2025-11-18]** – Created and used **SQL Views** (e.g., `LocalDrivingLicenseApplications_View`) with multiple joins, subqueries, CASE statements, and NULL handling:  
  - Simplified data retrieval.  
  - Improved maintainability.
- **[Throughout the project]** – Implemented DAL functions using `ref` parameters to retrieve multiple SQL fields in one call:  
  - Mapped SQL types to C# variables.  
  - Handled not-found records and exceptions for reliable and efficient data access.

## Problem Solving & Debugging

- **[2025-11-20]** – Refactored save logic to correctly handle parent/child class scenarios:
  - Ensured base data is saved first when inheritance is used.
- **[2025-12-11]** – Fixed shared-state issues caused by reference copying by creating new object instances where needed.
- **[Throughout the project]** – Improved **debugging skills** by resolving multiple issues and ensuring application logic works correctly.


## Tools & Development Environment

- **[Throughout the project]** – Used **Visual Studio** to structure multi-layer solutions clearly, improving readability and maintainability.
- **[Throughout the project]** – Practiced **Git & GitHub** for version control, maintaining structured commits and applying a feature-based development workflow.

## Security

- **[2025-12-21]** – Learned the risks of hardcoding connection strings and sensitive credentials.
- **[2025-12-21]** – Refactored `clsDataAccessSettings` class to read connection strings from **App.config** for improved security and maintainability.

 
## Project Delivery & Workflow

- **[2025-12-20]** – Completed the full project delivery cycle:  
  - Implemented feature-based development.  
  - Polished UI/UX.  
  - Performed final cleanup.  
  - Maintained a structured Git commit history reflecting professional workflow and project management practices.