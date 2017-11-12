using MarsRover.Business.Contracts;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Business.Commands
{
    public class Command
    {
        #region Ctor
        public Command(string _params)
        {
            this.CommandsList = GetCommandsList(_params);
        }
        #endregion

        
        #region Properties
        public List<ICommand> CommandsList { get; private set; } 
        #endregion


        #region Public-Methods

        public List<ICommand> GetCommandsList(string _params)
        {
            var commands = _params.ToCharArray();
            var allCommands = GetCommandsList();
            List<ICommand> _listcommands = new List<ICommand>();

            foreach (char item in commands)
            {
                if (allCommands.Contains(item))
                {
                    _listcommands.Add(GetCommand((CommandParams)Enum.Parse(typeof(CommandParams), item.ToString())));
                }
            }
            return _listcommands;
        }

        #endregion


        #region Helpers

        private ICommand GetCommand(CommandParams _params)
        {
            switch (_params)
            {
                case CommandParams.M:
                    return new Move();
                case CommandParams.L:
                    return new Left();
                case CommandParams.R:
                    return new Right();
                default: return null;
            }
        }
        private char[] GetCommandsList()
        {
            return string.Join("", Enum.GetNames(typeof(CommandParams))).ToCharArray();
            //return Enum.GetValues(typeof(CommandParams)).Cast<char>().ToArray();
        } 
        #endregion

    }
}
