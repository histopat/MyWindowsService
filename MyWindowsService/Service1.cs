using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            this.ServiceName = "MyWindowsService";
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                MessageBox.Show("Hello, this message comes from a Windows service!", "My Windows Service", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\ServiceLog.txt", ex.ToString());
            }
        }

        protected override void OnStop()
        {
        }
    }
}
