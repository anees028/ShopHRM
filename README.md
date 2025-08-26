# ShopHRM

ShopHRM is a Blazor WebAssembly application for managing employee information.

## Features

- Employee overview page
- Mock data service for employee data
- Responsive navigation menu
- Custom layout and styling

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Running the Application

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Set the Blazor WebAssembly project as the startup project.
4. Press F5 to run the application.

## Project Structure

- `App.razor` - Application root component
- `Program.cs` - Application startup and service configuration
- `Layout/` - Contains layout components (`MainLayout.razor`, `NavMenu.razor`)
- `Pages/` - Contains page components (`Home.razor`, `EmployeeOverview.razor`)
- `Models/MockDataService.cs` - Provides mock employee data
- `wwwroot/` - Static assets (CSS, index.html)

## What Has Been Done So Far

1. **Project Setup**
   - Created a Blazor WebAssembly project targeting .NET 8 and .NET 9.
2. **Layout and Navigation**
   - Implemented `MainLayout.razor` and `NavMenu.razor` for consistent UI and navigation.
3. **Pages**
   - Added `Home.razor` as the landing page.
   - Added `EmployeeOverview.razor` and its code-behind for displaying employee data.
4. **Data Layer**
   - Created `MockDataService.cs` to provide sample employee data for development.
5. **Styling**
   - Customized styles in `wwwroot/css/app.css`.
6. **Static Content**
   - Updated `wwwroot/index.html` for app hosting.

---
