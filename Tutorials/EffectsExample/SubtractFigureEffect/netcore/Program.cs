﻿using System;
using SpaceVIL.Common;

namespace SubtractFigureEffect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CommonService.GetSpaceVILInfo());
            CommonService.InitSpaceVILComponents();

            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
