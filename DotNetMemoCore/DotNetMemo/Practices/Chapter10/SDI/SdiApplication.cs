// Microsoft.VisualBasic.dll 
using Microsoft.VisualBasic.ApplicationServices;

namespace DotNetMemo
{
    public class SdiApplication : WindowsFormsApplicationBase
    {
        private static SdiApplication _instance = null;

        public SdiApplication()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        public static SdiApplication Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SdiApplication();
                }

                return _instance;
            }
        }

        protected override void OnCreateMainForm()
        {
            SdiMainForm.CreateForm();
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            SdiMainForm.CreateForm();
        }
    }
}
