# MyWindowsService
This project is a simple test application I developed as **my first Windows service**.

Its purpose is to observe firsthand the **Session 0 Isolation** feature introduced in Windows Vista.

## 🎯 Project Purpose
In Windows XP and earlier versions, both services and user applications ran in Session 0.

This posed a security risk because high-privilege services ran in the same session as user applications.

*With Windows Vista and later (Windows 7, 10, 11)*:
- Services were isolated in Session 0.
- User applications started running in Sessions 1 and later.
- Services were prevented from displaying a direct user interface (UI).

## 🧪 Test Scenario
- When the service starts, it attempts to display a window to the user using MessageBox.Show().

- However, this operation fails because the service is not running in **UserInteractive** mode.
- The following error is logged during operation: "System.InvalidOperationException: Showing a modal dialog box when the application is not running in UserInteractive mode is not a valid operation..."
- This error proves that **Session 0 Isolation** is working correctly.

## 📂 Project Structure
- **Service1.cs** → The main class of the service (the MessageBox test is performed in `OnStart`).
- **ProjectInstaller.cs** → The installer class required to install the service on Windows.
- **bin/Release** → The compiled service file (`MyWindowsService.exe`).

## ⚙️ Installation and Run
1. Compile the project with the target **.NET Framework 4.7.2 or later**.
2. Open a Command Prompt with administrator privileges.
3. Install the service with the **installutil** or **sc create** commands.
