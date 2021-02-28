﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Core.Logging
{
    public interface ILogger
    {
        void Debug(string message);

        void Debug(string format , params object[] args);

        void Debug(Exception exception , string message);
    }
}
