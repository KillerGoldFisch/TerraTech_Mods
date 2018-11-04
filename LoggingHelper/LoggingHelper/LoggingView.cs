using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace LoggingHelper
{
    public class LoggingView : MonoBehaviour
    {
        public void Append(string str)
        {
            this.log = this.log + str + "\n";
            this.logLines++;
        }

        public LoggingView()
        {
            GCore.Logging.Log.LoggingHandler.Add(
                new GCore.Logging.Logger.UnityLogger(this));
            LoggingView._inst = this;
        }

        private void OnGUI()
        {
            if (this.ShowGUI) {
                GUI.Window(0, this.Window, new GUI.WindowFunction(this.GUIWindow), "Log");
                return;
            }
            if (GUI.Button(new Rect(this.Window.width - 15f, 0f, 15f, 15f), "-")) ShowGUI = true;
        }

        private void GUIWindow(int ID)
        {
            float num = Mathf.Max(15f * this.logLines + 15f, 66f);
            this.scroll = GUI.BeginScrollView(new Rect(0f, 15f, 400f, 65f), this.scroll, new Rect(0f, 0f, 380f, num));
            GUI.TextArea(new Rect(0f, 0f, 385f, num), this.log);
            GUI.EndScrollView();
            if (GUI.Button(new Rect(this.Window.width - 15f, 0f, 15f, 15f), "X")) {
                this.ShowGUI = false;
            }
        }

        private Rect Window = new Rect(0f, 0f, 400f, 80f);
        private Vector2 scroll = Vector2.zero;
        public string log = "";
        public int logLines = 0;
        public static LoggingView _inst;
        private bool ShowGUI;
    }
}
