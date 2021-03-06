﻿namespace MyApp.Core
{
    using MyApp.Core.Commands.Contracts;
    using MyApp.Core.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string Suffix = "Command";
        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] inputArgs)
        {
            var commandName = inputArgs[0] + Suffix;
            var commandParameters = inputArgs.Skip(1).ToArray();

            var type = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandName);

            if (type == null)
            {
                throw new ArgumentNullException("Invalid command");
            }

            var constructor = type.GetConstructors().FirstOrDefault();

            var constructorParams = constructor.GetParameters()
                .Select(x => x.ParameterType)
                .ToArray();


            var services = constructorParams.Select(x => this.serviceProvider.GetService(x)).ToArray();
            var command = (ICommand)Activator.CreateInstance(type, services);

            var result = command.Execute(commandParameters);

            return result;
        }
    }
}
