﻿using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using Rhino.UI;
using System;
using System.Collections.Generic;

namespace MyRhinoPlugin2
{
    public class MyRhinoCommand2 : Command
    {
        public MyRhinoCommand2()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static MyRhinoCommand2 Instance { get; private set; }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName => "MyRhinoCommand2";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            var version = typeof(MaterialDesignThemes.Wpf.ButtonAssist).Assembly.GetName().Version.ToString();
            Dialogs.ShowMessage(version, "Plugin2");

            // ---
            return Result.Success;
        }
    }
}
