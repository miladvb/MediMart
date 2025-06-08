# 🚀 MediMart (Meds Finder)

**Find your Meds faster.**  
Meds Finder is a lightweight, smart web app that helps users locate medications across local pharmacies without relying on a centralized medication database.

---

## What It Does

Instead of tracking real-time stock of medications, Meds Finder simplifies the process:

1. **User submits** a request with the medication name.
2. **All pharmacies** in the network receive the request.
3. **Pharmacy staff** confirm if they have it in stock.
4. The user is provided with the **pharmacy's location and contact information**.

✅ Efficient  
✅ Decentralized  
✅ Privacy-friendly

---

## 🛠 Tech Stack

| Layer      | Technology             |
|------------|------------------------|
| Backend    | ASP.NET Web API        |
| Frontend   | React.js               |
| Database   | Microsoft SQL Server   |

---

## Setup Guide

### Prerequisites

Make sure you have the following installed:

- [Node.js](https://nodejs.org/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server

### 1. Clone the Repository

```bash
git clone https://github.com/Kasraco/DrugStore.git
cd DrugStore
```

### 2. Backend Configuration
Update connection settings in backend/Presentation/appsettings.json:

```bash
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

Then run:

```bash
cd backend
dotnet restore
dotnet build
```

### 3. Frontend Configuration

Navigate to the frontend directory, install dependencies, and build the application:

```bash
cd FrontEnd/reactivities-app
npm install
npm run build-all
```
### 3. Start the Application
To run both the backend and frontend together, use:

```bash
npm run start-all
```
