﻿namespace _1.Logger.Models
{
    using _1.Logger.Models.Contracts;
    using System.Collections.Generic;
    using System.Text;

    public class Logger : ILogger
    {
        private ICollection<IAppender> appenders;

        public Logger(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> ConsoleAppender => (IReadOnlyCollection<IAppender>)this.appenders;

        public void Log(IError error)
        {
            foreach (var appender in this.appenders)
            {
                if (appender.Level <= error.Level)
                {
                    appender.Append(error);
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Logger info");
            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
