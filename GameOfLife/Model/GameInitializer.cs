using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Model
{
    public class GameInitializer
    {
        private IList<IList<Cell>> field;
        private readonly bool[][] initialState;

        public GameInitializer(bool[][] initialState)
        {
            this.initialState = initialState;
        }

        public IList<IList<Cell>> Initialize()
        {
            SetUpGame();
            return field;
        }

        private void SetUpGame()
        {
            field = new List<IList<Cell>>();
            foreach (bool[] rowState in initialState)
            {
                SetUpRow(rowState);
            }
        }

        private void SetUpRow(bool[] initialRowState)
        {
            
            field.Add(new List<Cell>());
            foreach (bool isAlive in initialRowState)
            {
                SetUpCell(isAlive);
            }
        }

        private void SetUpCell(bool isAlive)
        {
            var row = field.Last();
            var cell = CreateCell(isAlive);
            row.Add(cell);

            new NieghborhoodInitializer(field, cell).Initialize();
        }
        
        private static Cell CreateCell(bool cellState)
        {
            if (cellState)
            {
                return Cell.CreateAlive();
            } 
            return Cell.CreateDead();
        }
    }
}
