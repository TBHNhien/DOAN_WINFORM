﻿using BaiLon;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Luong_nhan_vien_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lamlai_CAFE
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
            //Application.Run(new fViewLuongNV());
        }
    }
}
