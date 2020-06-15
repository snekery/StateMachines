namespace StateMachines
{
    /// <summary>
    /// Base class for providing a finite state machine.
    /// </summary>
    public class StateMachine
    {
        /// <summary>
        /// Property containing the current state.
        /// </summary>
        public State CurrentState
        {
            private set
            {
                if (currentState != null) currentState.Exit();
                currentState = value;
                value.Enter();
            }
            get
            {
                return currentState;
            }
        }

        private State currentState = null;
        /// <summary>
        /// Initializes the StateMachine with an initial state.
        /// </summary>
        /// <param name="initialState">The initial State.</param>
        public void Initialize(State initialState)
        {
            if (CurrentState != null) return;
            CurrentState = initialState;
        }
        /// <summary>
        /// Transitions to a new State from the current state.
        /// </summary>
        /// <param name="newState">The new state to transition to.</param>
        public void TransitionState(State newState) => CurrentState = newState;
    }
}