﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeCreator
{
    static class Program
    {
        public static ConfigForm configForm;
        public static Creator creator;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            configForm = new ConfigForm();
            creator = new Creator();
            Application.Run(configForm);
        }
    }
}
