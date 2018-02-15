using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Logging;

namespace MvxFormsVmDuplication.UWP
{
    public class VoidLogProvider : IMvxLogProvider
    {
        private readonly EmptyVoidLog voidLog;

        public VoidLogProvider()
        {
            voidLog = new EmptyVoidLog();
        }

        public IMvxLog GetLogFor<T>()
        {
            return voidLog;
        }

        public IMvxLog GetLogFor(string name)
        {
            return voidLog;
        }

        public IDisposable OpenNestedContext(string message)
        {
            throw new NotImplementedException();
        }

        public IDisposable OpenMappedContext(string key, string value)
        {
            throw new NotImplementedException();
        }

        public class EmptyVoidLog : IMvxLog
        {
            public bool Log(MvxLogLevel logLevel, Func<string> messageFunc, Exception exception = null, params object[] formatParameters)
            {
                Debug.WriteLine(messageFunc(), formatParameters);
                return true;
            }
        }
    }
}
