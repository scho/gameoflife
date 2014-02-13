using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Model
{
    public class Game
    {
        private readonly IList<IList<Cell>> field;

        public Game(bool[][] initialState)
        {
            field = new GameInitializer(initialState).Initialize();
        }

        public void Tick()
        {
            StoreNextState();
            ApplyNextState();
        }

        public IList<string> ToStringCollection()
        {
            return field.Select(row => string.Join("", row.Select(cell => cell.ToString()))).ToList();
        }

        private void StoreNextState()
        {
            foreach (var cell in AllCells())
            {
                cell.StoreNextState();
            }
        }

        private void ApplyNextState()
        {
            foreach (var cell in AllCells())
            {
                cell.ApplyNextState();
            }
        }

        private IEnumerable<Cell> AllCells()
        {
            var allCells = new List<Cell>();

            foreach (var row in field)
            {
                allCells.AddRange(row);
            }

            return allCells;
        }
    }
}
