# Expense Tracker using ASP.NET Core

## Overview

Welcome to the Expense Tracker, an application built using ASP.NET Core using SyncFusion Components. This repository contains the source code for an expense tracking system that helps you manage your personal or business expenses and income efficiently.

## Features

1. **Expense Logging:** Add, edit, and categorize your expenses and income. Each entry includes details such as date, description, amount, and category.

2. **Category Management:** Create and manage expense categories for better organization.

3. **Income Tracking:** Record your sources of income to help maintain a balanced financial overview.

4. **Reports and Analysis:** Visualize your spending habits through reports and charts.

5. **Authentication:** Secure login and registration system to keep your financial data private.

## Getting Started

To run the Expense Tracker using ASP.NET Core on your local machine, follow these steps:

### Prerequisites

1. [.NET Core](https://dotnet.microsoft.com/download/dotnet): Make sure you have .NET Core installed.

2. [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/): You can use any code editor, but Visual Studio or Visual Studio Code are recommended.

### Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/your-username/expense-tracker.git
   ```

2. Change your working directory to the project folder:

   ```bash
   cd expense-tracker
   ```

3. Restore the NuGet packages:

   ```bash
   dotnet restore
   ```

4. Set up the database by running the following commands in the project root directory:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. Launch the application:

   ```bash
   dotnet run
   ```

6. Access the Expense Tracker in your web browser by navigating to `http://localhost:5000` or `https://localhost:5001` for HTTPS.

## Usage

The Expense Tracker is designed for easy and intuitive use. Here are some common actions you can perform:

- **Login/Register:** Users can create accounts or log in to manage their expenses.

- **Manage Expenses:** Add, edit, or delete expenses, categorize them, and add income sources.

- **Analyze Expenses:** Utilize the reports and charts to understand your spending patterns.

- **Manage Categories:** Create and edit categories to organize your expenses better.

## Acknowledgments

This Expense Tracker was created using ASP.NET Core, a powerful framework for building web applications. We also acknowledge the open-source community for their contributions to the libraries and tools used in this project.

