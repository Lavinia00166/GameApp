using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class GameCommand : Command
    {
        public Operations operation { get; set; }

        private GameTable _gameTable;

        public GameCommand(GameTable gameTable, Operations operation) {
           this.operation = operation;
           _gameTable = gameTable;
            
            }

        private Operations undoOperation(Operations operation)
        {
            switch(operation)
            {
                case Operations.UP: return Operations.DOWN;
                case Operations.DOWN: return Operations.UP;
                case Operations.RIGHT: return Operations.LEFT;
                case Operations.LEFT: return Operations.RIGHT;
                default: throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }

        }

        public override void Execute()
        {
            _gameTable.Move(operation);
        }

        public override void Unexecute()
        {
            _gameTable.Move(undoOperation(operation));
        }
    }
}
