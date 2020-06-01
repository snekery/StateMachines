namespace ElementStudio.StateMachines
{
    /// <summary>
    /// Base class for providing a finite state machine.
    /// </summary>
    public class StateMachine
    {
        /// <summary>
        /// Property containing the current state.
        /// </summary>
        /// <value></value>
        public State CurrentState
        {
            private set
            {
                CurrentState.Exit();
                CurrentState = value;
                value.Enter();
            }
            get => CurrentState;
        }
        /// <summary>
        /// Initializes the StateMachine with an initial state.
        /// </summary>
        /// <param name="initialState">The initial State.</param>
        public void Initialize(State initialState) => CurrentState = initialState;
        /// <summary>
        /// Transitions to a new State from the current state.
        /// </summary>
        /// <param name="newState">The new state to transition to.</param>
        public void TransitionState(State newState) => CurrentState = newState;
    }
}