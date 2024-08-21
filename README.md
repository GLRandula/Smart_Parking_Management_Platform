# Parking Management System

## Overview

The Parking Management System is a C# Windows Forms application designed to streamline the process of managing parking slots, vehicles, and bookings. This system provides a user-friendly interface for parking attendants or administrators to add vehicles, book parking slots, and retrieve data efficiently. It is built using the Guna UI framework for a modern and polished frontend experience, backed by a robust .NET backend. The data is stored and managed using a MySQL database.

## Features

- **Add Vehicle**: Easily add vehicle details to the database. When booking a slot for a vehicle, the user only needs to enter the vehicle number, and the system will auto-fill the rest of the details from the database.
  
- **Book Vehicle**: Assign parking slots to vehicles quickly. The system ensures that slots are accurately updated and can be retrieved later as needed.

- **Retrieve Data**: View and manage vehicle and booking records through an integrated data grid. Users can update or delete records, ensuring that the database remains current.

- **User Authentication**: Secure login functionality that ensures only authorized users can access and modify the system’s data.

## Technologies Used

### Frontend
- **C# Windows Forms**: Provides a rich and responsive user interface.
- **Guna UI Framework**: Enhances the appearance of the application with modern UI components and design elements.

### Backend
- **.NET Framework**: Handles the application logic and communication between the frontend and the database.

### Database
- **MySQL**: A reliable and efficient database system used to store vehicle information, booking records, and user data.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/parking-management-system.git
