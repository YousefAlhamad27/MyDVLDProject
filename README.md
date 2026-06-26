# Driving License Management System (DVLD)

A comprehensive Windows Forms desktop application designed to manage driver records, license issuance, and user administration, backed by a robust SQL Server database.

## Tech Stack
* Frontend: Windows Forms (C#)
* Database: SQL Server
* Architecture: 3-Tier Architecture

## Architecture Overview
The application is structured using a strict 3-tier architecture to decouple the UI from data processing, ensuring clean, maintainable code:
* Presentation Layer (DVLDPresentationLayer): The Windows Forms UI where user interaction occurs.
* Business Layer (DVLDBusinessLayer): Handles validation, business rules, and logic for license processing.
* Data Access Layer (DVLDDataAccessLayer): Executes optimized CRUD operations and communicates directly with the SQL Server database.

## Key Features
* Driver Record Management: Add, update, and manage detailed applicant profiles.
* License Processing: Logic for issuing, renewing, and tracking driving licenses.
* Structured Data Handling: Fully normalized database schema ensuring data integrity and fast query execution.

## Local Setup
1. Clone the repository.
2. Restore the SQL Server database using the provided scripts.
3. Update the database connection string in the configuration file.
4. Open the solution (DVLD.sln) in Visual Studio and run the application.
