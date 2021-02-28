using Automation.Core.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Core.Components
{
    public interface Ifluent
    {
        T ChangeContext<T>();

        T ChangeContext<T>(ILogger logger);

        T ChangeContext<T>(string application);

        T ChangeContext<T>(string application , ILogger logger);
    }
}
