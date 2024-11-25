using Microsoft.VisualBasic.ApplicationServices;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Model.GameLogic;

namespace TickTackToe.Model
{
    internal sealed class GameCore
    {
        public const int FiedlWidth = 3;

        private int turnCount;
        private TickTackType turnType;

        private Player _player1;
        private Player _player2;
        
        private TickTackType?[,] _field = new TickTackType?[3,3];

        public event Action<ValueTuple<int, int>> FieldChangedByMe;
        public event Action FieldIsFull;
        public event Action<TickTackType> GameEnded;
        public event Action Draw;

        public GameCore()
        {
            turnCount = 0;
        }

        public void InitPlayersRandomly()
        {
            var isCross = Random.Shared.Next((int)TickTackType.Zero, (int)TickTackType.Cross + 1);

            if(isCross == (int)TickTackType.Cross)
            {
                _player1 = new(TickTackType.Cross);
                _player2 = new(TickTackType.Zero);
            }
            else
            {
                _player1 = new(TickTackType.Zero);
                _player2 = new(TickTackType.Cross);
            }
        }

        public void AssignFirstPlayer(UserDto user)
        {
            _player1.Name = user.UserName;
        }

        public void AssingSecondPlayer(UserDto user)
        {
            _player2.Name = user.UserName;
        }

        public Player DefinePlayerForUser(UserDto user)
        {
            if (_player1.Name.ToUpper().Equals(user.UserName.ToUpper()))
            {
                return _player1;
            }

            return _player2;
        }

        public bool IsTurnFirst(UserDto user) => DefinePlayerForUser(user).Type == TickTackType.Cross;

        public TickTackType DefineTurn() => turnCount % 2 == 0 ? TickTackType.Cross : TickTackType.Zero;

        public bool MakeTurn(UserDto user, int posX, int posY)
        {
            if (CheckForGameCompletion())
            {
                return false;
            }

            var player = DefinePlayerForUser(user);
            var turn = DefineTurn();
            
            bool result = false;

            if(turn == player.Type)
            {
                if (_field[posX, posY] == null)
                {
                    _field[posX, posY] = player.Type;
                    turnCount++;
                    result = true;

                    FieldChangedByMe?.Invoke((posX, posY));
                }
            }
           

            return result;
        }

        private bool CheckIfFieldIsFull()
        {
            int counter = 0;

            for(int i = 0; i < _field.GetLength(0); i++)
            {
                for(int j = 0; j <  _field.GetLength(1); j++)
                {
                    if (_field[i, j] != null)
                    {
                        counter++;
                    }
                }
            }

            return counter == _field.Length;
        }

        private bool CheckForAWinner()
        {
            bool thereIsAWinner = false;

            if ((_field[0, 0] == _field[0, 1]) && (_field[0, 1] == _field[0, 2]) && _field[0, 0] is not null)
            {
                thereIsAWinner = true;
            }
            else if ((_field[1, 0] == _field[1, 1]) && (_field[1, 1] == _field[1, 2]) && _field[1, 0] is not null)
            {
                thereIsAWinner = true;
            }
            else if ((_field[2, 0] == _field[2, 1]) && (_field[2, 1] == _field[2, 2]) && _field[2, 0] is not null)
            {
                thereIsAWinner = true;
            }
            else if ((_field[0, 0] == _field[1, 0]) && (_field[1, 0] == _field[2, 0]) && _field[0, 0] is not null)
            {
                thereIsAWinner = true;
            }
            else if ((_field[1, 0] == _field[1, 1]) && (_field[1, 1] == _field[1, 2]) && _field[1, 0] is not null)
            {
                thereIsAWinner = true;
            }
            else if ((_field[2, 0] == _field[2, 1]) && (_field[2, 1] == _field[2, 2]) && _field[2, 0] is not null)
            {
                thereIsAWinner = true;
            }
            else if ((_field[0, 0] == _field[1, 1]) && (_field[1, 1] == _field[2, 2]) && _field[0, 0] is not null)
            {
                thereIsAWinner = true;
            }
            else if ((_field[0, 2] == _field[1, 1]) && (_field[1, 1] == _field[2, 0]) && _field[0, 2] is not null)
            {
                thereIsAWinner = true;
            }

            if (thereIsAWinner)
            {
                return true;
            }

            return false;
        }

        public bool CheckForGameCompletion()
        {
            if (CheckIfFieldIsFull())
            {
                FieldIsFull.Invoke();

                return true;
            }
            else if(CheckForAWinner())
            {
                GameEnded.Invoke(turnType);

                return true;
            }
            else if(turnCount == _field.Length)
            {
                Draw.Invoke();
            }

            return false;
        }
    }
}
