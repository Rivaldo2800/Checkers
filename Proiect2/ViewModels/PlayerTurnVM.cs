using Proiect2.Models;
using Proiect2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2.ViewModels
{
    public class PlayerTurnVM : BaseNotification
    {
        private GameLogic gameLogic;
        private PlayerTurn playerTurn;

        public PlayerTurnVM(GameLogic gameLogic, PlayerTurn playerTurn)
        {
            this.gameLogic = gameLogic;
            this.playerTurn = playerTurn;
        }

        public PlayerTurn PlayerIcon
        {
            get
            {
                return playerTurn;
            }
            set
            {
                playerTurn = value;
                NotifyPropertyChanged("PlayerIcon");
            }
        }
    }
}