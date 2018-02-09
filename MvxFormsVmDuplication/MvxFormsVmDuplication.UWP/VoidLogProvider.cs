using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Logging;

namespace MvxFormsVmDuplication.UWP
{
    public class VoidLogProvider : IMvxLogProvider
    {
        private readonly EmptyVoidLog _voidLog;

        public VoidLogProvider()
        {
            _voidLog = new EmptyVoidLog();
        }

        public IMvxLog GetLogFor<T>()
        {
            return _voidLog;
        }

        public IMvxLog GetLogFor(string name)
        {
            return _voidLog;
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
                return true;
            }
        }
    }
}
