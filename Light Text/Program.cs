using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Light_Text
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
        	if (SingleInstance.IsRunning) {
            	new InterProcessCommunication("LightTextIPC").SendMessage(String.Join("?", args));
        		return;
    		}
        	
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainF(args));
        }
    }
}
