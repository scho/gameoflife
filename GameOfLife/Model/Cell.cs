namespace GameOfLife.Model
{
    public class Cell
    {
        private readonly CellNeighbors neighbors;

        private readonly CellState state;

        public static Cell CreateAlive()
        {
            return new Cell(CellState.CreateAliveState());
        }

        public static Cell CreateDead()
        {
            return new Cell(CellState.CreateDeadState());
        }

        private Cell(CellState state)
        {
            neighbors = new CellNeighbors();
            this.state = state;
        }

        public override string ToString()
        {
            if (state.IsAlive())
            {
                return "o";
            }
            return "_";
        }

        public void AddNeighbor(Cell neighbor)
        {
            neighbors.AddCell(neighbor);
        }

        public bool IsAlive()
        {
            return state.IsAlive();
        }

        public void StoreNextState()
        {
            var currentState = state.IsAlive();
            var nextState = neighbors.GetNextState(currentState);
            state.StoreNextState(nextState);
        }

        public void ApplyNextState()
        {
            state.ApplyNextState();
        }
    }
}
