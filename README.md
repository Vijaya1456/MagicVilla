# 🏡 MagicVilla – Cloud-Native Villa Management Platform

MagicVilla is a full-stack, cloud-native villa booking and management system designed to demonstrate enterprise-grade API development, secure authentication, modern UI design, and hybrid cloud integration. Built using **.NET Core Web API** for the backend and **React.js** with **TypeScript** for the frontend, MagicVilla is optimized for scalability, observability, and performance on **Microsoft Azure** and **AWS**.

---

## 🚀 Features

- ✅ Full **CRUD API** for villa listings, users, and reservations  
- 🔐 Secure authentication with **JWT**, **OAuth2**, and **RBAC**  
- ☁️ Hybrid cloud deployment using **Azure** and **AWS**  
- 📦 Microservices-ready architecture using **RESTful APIs**  
- 🔄 CI/CD automation with **Azure DevOps** and **GitHub Actions**  
- 📈 Real-time monitoring via **Azure Monitor**, **AWS CloudWatch**, and **DataDog**  
- 💡 Built with modular, scalable, and test-driven design principles  

---

## 🛠 Tech Stack

### 🎯 Backend
- **.NET 6**, **C#**, **ASP.NET Core Web API**
- **Entity Framework Core**, **LINQ**
- **SQL Server** / **Azure SQL Database**
- **JWT**, **OAuth2**, **RBAC**

### 🎨 Frontend
- **React.js**, **TypeScript**, **Redux**
- **HTML5**, **CSS3**

### ☁️ Cloud & DevOps
- **Microsoft Azure**: App Services, Functions, Blob Storage, Key Vault, Azure Monitor
- **AWS**: Lambda, S3, CloudWatch (secondary support)
- **CI/CD**: Azure DevOps, GitHub Actions
- **Infrastructure**: Docker, Terraform (basic)

---

## 🧱 Architecture Diagram

```text
[ React.js + TypeScript (SPA) ]
               |
      [ ASP.NET Core Web API ]
               |
   [ Azure SQL / SQL Server DB ]
               |
[ Azure App Services | AWS Lambda ]
         | Blob Storage / S3 |

📦 Project Structure

MagicVilla/
├── MagicVilla_API/          # .NET Core backend project
├── MagicVilla_React/        # React frontend project
├── README.md
└── ...

⚙️ Getting Started
🔧 Prerequisites
.NET 6 SDK

Node.js (v16+)

SQL Server or Azure SQL

Azure/AWS accounts (optional for deployment)

🖥 Backend Setup (.NET Core API)
bash
Copy
Edit
cd MagicVilla_API
dotnet restore
dotnet ef database update
dotnet run

💻 Frontend Setup (React.js)
bash
Copy
Edit
cd MagicVilla_React
npm install
npm start

⚙️ Configuration
Update the appsettings.json file with your DB connection string and JWT secrets.

Set environment variables or use Azure Key Vault in production.
