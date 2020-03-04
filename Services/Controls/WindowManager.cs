using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.Services.Controls
{
    public class WindowManager
    {
        /// <summary>
        /// Holds all the windows to display.
        /// </summary>
        public List<Window> Windows { get; set; }

        /// <summary>
        /// Initializations for the WindowManager
        /// </summary>
        public WindowManager()
        {
            Windows = new List<Window>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowName"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowName"></param>
        /// <param name="assemblyType"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowName"></param>
        public void KillWindow(string windowName)
        {

        }
    }
}
