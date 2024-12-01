using Microsoft.VisualBasic.ApplicationServices;
using Shared.Api.Messages;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TickTackToe.Model.GameLogic;
using TickTackToe.Model.Helpers;

namespace TickTackToe.Model
{
    internal sealed class GameCore
    {
        public const int FiedlWidth = 3;

        private int _turnCount;
        private TickTackType turnType;

        public Player Me { get; private set; }

        private Player _player1;
        private Player _player2;
        
        private TickTackType?[,] _field = new TickTackType?[3,3];
        private GameChangedParameter _gameState;

        public event Action<bool, int, int> FieldChangedByMe;
        public event Action FieldIsFull;
        public event Action<TickTackType> GameEnded;
        public event Action Draw;

        public GameCore()
        {
            _turnCount = 0;
        }

        public void AssignFirstPlayer(string name, string id)
        {
            _player1 = new(TickTackType.Cross);
            _player1.Name = name;
            _player1.Id = id;
        }

        public void AssingSecondPlayer(string name, string id)
        {
            _player2 = new(TickTackType.Zero);
            _player2.Name = name;
            _player2.Id = id;
        }

        public void DefinePlayerForMe(string id)
        {
            if (_player1.Id.Equals(id))
            {
                Me = _player1;
            }
            else
            {
                Me = _player2;
            }
        }

        public bool IsTurnFirst(string id) => Me.Type == TickTackType.Cross;

        public TickTackType DefineTurn() => _turnCount % 2 == 0 ? TickTackType.Cross : TickTackType.Zero;

        public bool MakeTurn(int posX, int posY, string toUserId)
        {
            if (CheckForGameCompletion())
            {
                return false;
            }

            var turn = DefineTurn();
            
            bool result = false;

            if(turn == Me.Type)
            {
                if (_field[posX, posY] == null)
                {
                    _field[posX, posY] = Me.Type;
                    _turnCount++;
                    result = true;

                    var isCorss = Me.Type == TickTackType.Cross;
                    FieldChangedByMe(isCorss, posX, posY);

                    _gameState = new GameChangedParameter(_turnCount, posX, posY, isCorss, toUserId);
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
            else if(_turnCount == _field.Length)
            {
                Draw.Invoke();
            }

            return false;
        }

        internal bool LoadState(GameChangedParameter parameter)
        {
            _turnCount = parameter.TurnCount;

            var currentCellType = parameter.IsCross
               ? TickTackType.Cross
               : TickTackType.Zero;

            _field[parameter.PosY, parameter.PosX] = currentCellType;

            return CheckForGameCompletion();
        }

        public GameChangedParameter SaveState() => _gameState;
    }
}
