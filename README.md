# Classes Registration System

Welcome to the Classes Registration System GitHub repository! This project is a Windows application developed using Visual Studio 2022 and Microsoft SQL Server Management Studio 2019. 
It facilitates the registration of Student and utilizes C# for coding, SQL for the database, stored procedures, and datasets.

## Setup Instructions

### Prerequisites

Make sure you have the following installed:

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [Microsoft SQL Server Management Studio 2019](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

### Database Setup

1. Open Microsoft SQL Server Management Studio.
2. Execute the SQL scripts provided in the `Database` directory to create the necessary database and tables.
3. ensure to execute each script in the order present in databsase folder.
4. Every Query is done using Stored Procedures.
   
### Visual Studio Setup

1. Clone the repository to your local machine.

   ```bash
   git clone https://github.com/your-username/classes-registration-system.git

### Languages Used

This project is primarily built using the following programming/scripting languages:

- **C#**
  ![C#](https://img.shields.io/badge/C%23-blue)

- **SQL**
  ![SQL](https://img.shields.io/badge/SQL-orange)


### DB Setup in visual Studio

1. Open the project in Visual Studio 2022.
1. Set up the database connection in the App.config file. Update the connection string with your SQL Server details.

```xml
  <connectionStrings>
  <add name="ClassesRegistrationConnectionString" connectionString="Data Source=yourservername;Initial Catalog=ClassReg;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>


**### Usage**

Run the application from Visual Studio.
Navigate through the interface to mainpage.cs and set that as startup item.


**### Features**

This project incorporates several features to enhance functionality and user experience:
- **C# and WinForms:** The application is developed using C# for robust logic and Windows Forms for a user-friendly interface.
- **SQL Database:** Utilizes a Microsoft SQL Server database to efficiently store and retrieve data.
- **Stored Procedures:** Implements stored procedures for database interaction, ensuring efficient and secure data operations.
- **Datasets:** Utilizes datasets to manage and manipulate data within the application, providing a structured approach to data handling.
Feel free to explore and leverage these features to enhance your experience with the Classes Registration System.


## Contact

If you have any questions or suggestions, feel free to reach out:

- **Email:** [walidkadri1177@gmail.com](mailto:walidkadri1177@gmail.com)



