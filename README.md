# Drugstore Finder

## Overview

Drugstore Finder is a web application designed to help users locate medications in pharmacies efficiently. Instead of maintaining a database of available medications, the system stores only the location and management details of pharmacies.

### How It Works

- Users send a message with the required medication details.
- The request is sent to all pharmacies.
- Pharmacy staff can confirm availability if they have the requested medication.
- The system then shares the pharmacy's location with the user.
- This process helps patients find medications more easily across a city, county, or province.

## Technologies Used

- **Backend:** ASP.NET Web API
- **Frontend:** React.js
- **Database:** MSSQL Server

## Installation & Setup

### Prerequisites

- Node.js & npm installed
- .NET SDK installed
- SQL Server installed & configured

### Clone the Repository

```sh
git clone https://github.com/Kasraco/DrugStore.git
cd DrugStore
```

### Configure Backend

1. Navigate to `backend/Presentation/appsettings.json` and update the following settings:

```json
"ConnectionStrings": {
  "KRBConnectionString": "Data Source=.\\SQLEXPRESS;Initial Catalog=dbDrugStore;TrustServerCertificate=True; Integrated Security=true"
},
"EmailInfo": {
  "Host": "smtp.yourDomain.com",
  "From": "info@yourDomain.com",
  "Port": 587,
  "EnableSsl": 1,
  "Username": "info",
  "Password": "P@3sw0rd"
}
```

2. Restore dependencies and build the backend:

```sh
cd backend
 dotnet restore
 dotnet build
```

### Configure Frontend

1. Install dependencies and build the frontend:

```sh
cd FrontEnd/reactivities-app
npm install
npm run build-all
```

### Run the Application

To start both backend and frontend simultaneously, run the following command:

```sh
npm run start-all
```

## Contribution

Feel free to fork this repository, create a branch, and submit a pull request with improvements.

## License

This project is licensed under the MIT License.

---

**Note:** Ensure your SMTP settings and database connection string are correctly configured before running the application.
