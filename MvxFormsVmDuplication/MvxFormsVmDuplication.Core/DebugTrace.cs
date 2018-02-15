using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MvvmCross.Platform.Platform;

namespace MvxFormsVmDuplication.Core
{
    public class DebugTrace : IMvxTrace
    {
        public void Trace(MvxTraceLevel level, string tag, Func<string> message)
        {
            Debug.WriteLine(tag + ":" + level + ":" + message());
        }

        public void Trace(MvxTraceLevel level, string tag, string message)
        {
            Debug.WriteLine(tag + ":" + level + ":" + message);
        }

        public void Trace(MvxTraceLevel level, string tag, string message, params object[] args)
        {
            Debug.WriteLine(tag + ":" + level + ":" + message);
        }
    }
}