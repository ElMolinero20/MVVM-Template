using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.Services.Controls
{
    class WindowManager
    {
        public List<Window> Windows { get; set; }

        public WindowManager()
        {
            Windows = new List<Window>();
        }


        public void LoadWindow(string windowName)
        {
            object instance = Assembly.GetExecutingAssembly().CreateInstance(windowName);

            if (instance is Window)
            {
                Window windowInstance = instance as Window;
                windowInstance.ShowDialog();
                Windows.Add(windowInstance);
            }
        }


        public void LoadWindow(string windowName, Type assemblyType)
        {
            object instance = Assembly.GetAssembly(assemblyType).CreateInstance(windowName);

            if (instance is Window)
            {
                Window windowInstance = instance as Window;
                windowInstance.ShowDialog();
                Windows.Add(windowInstance);
            }
        }


        public void KillWindow(string windowName)
        {

        }
    }
}
