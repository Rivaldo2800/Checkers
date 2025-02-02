﻿using Proiect2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Proiect2.Commands;

namespace Proiect2.ViewModels
{
    public class ButtonInteractionVM : BaseNotification
    {
        private GameLogic gameLogic;
        private ICommand resetCommand;
        private ICommand saveCommand;
        private ICommand aboutCommand;
        private ICommand loadCommand;
        private ICommand statisticsCommand;

        public ButtonInteractionVM(GameLogic gameLogic)
        {
            this.gameLogic = gameLogic;
        }

        public ICommand ResetCommand
        {
            get
            {
                if (resetCommand == null)
                {
                    resetCommand = new NonGenericCommand(gameLogic.ResetGame);
                }
                return resetCommand;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new NonGenericCommand(gameLogic.SaveGame);
                }
                return saveCommand;
            }
        }

        public ICommand LoadCommand
        {
            get
            {
                if (loadCommand == null)
                {
                    loadCommand = new NonGenericCommand(gameLogic.LoadGame);
                }
                return loadCommand;
            }
        }

        public ICommand AboutCommand
        {
            get
            {
                if (aboutCommand == null)
                {
                    aboutCommand = new NonGenericCommand(gameLogic.About);
                }
                return aboutCommand;
            }
        }

        public ICommand StatisticsCommand
        {
            get
            {
                if (statisticsCommand == null)
                {
                    statisticsCommand = new NonGenericCommand(gameLogic.Statistics);
                }
                return statisticsCommand;
            }
        }
    }
}
