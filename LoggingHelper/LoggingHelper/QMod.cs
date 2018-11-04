using GCore.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace LoggingHelper
{
    public class QMod
    {
        public static void main()
        {
            //File.WriteAllText("c:\\tmp\\tt.log", "Hello World");

            new GameObject("LoggingView Object", new Type[]
            {
                typeof(LoggingView)
            });
            Log.Info("LoggingView Loaded");
        }
    }
}
