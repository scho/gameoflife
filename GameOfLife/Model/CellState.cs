namespace GameOfLife.Model
{
    public class CellState
    {
        private bool currentState;
        private bool nextState;

        public static CellState CreateAliveState()
        {
            return new CellState
            {
                currentState = true
            };
        }

        public static CellState CreateDeadState()
        {
            return new CellState
            {
                currentState = false
            };
        }

        public bool IsAlive()
        {
            return currentState;
        }

        public void ApplyNextState()
        {
            currentState = nextState;
        }

        public void StoreNextState(bool value)
        {
            nextState = value;
        }
    }
}