using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ServiceProcess;
using System.Configuration.Install;

[RunInstaller(true)]
public class ProjectInstaller : Installer
{
    public ProjectInstaller()
    {
        var processInstaller = new ServiceProcessInstaller();
        var serviceInstaller = new ServiceInstaller();

        processInstaller.Account = ServiceAccount.LocalSystem;

        serviceInstaller.ServiceName = "MyWindowsService";
        serviceInstaller.DisplayName = "My Windows Service";
        serviceInstaller.StartType = ServiceStartMode.Manual;

        Installers.Add(processInstaller);
        Installers.Add(serviceInstaller);
    }
}