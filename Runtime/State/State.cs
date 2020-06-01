namespace ElementStudio.StateMachines
{
    /// <summary>
    /// Base class for creating States for use with a StateMachine.
    /// </summary>
    public abstract class State
    {
        /// <summary>
        /// Reference to the StateMachine that this State is running under.
        /// </summary>
        protected StateMachine stateMachine;

        protected State(StateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }
        /// <summary>
        /// Called when the State is entering execution.
        /// </summary>
        public virtual void Enter()
        {

        }
        /// <summary>
        /// Handles input.
        /// </summary>
        public virtual void HandleInput()
        {

        }
        /// <summary>
        /// Processes updates as if they were in Unity's Update function.
        /// </summary>
        /// <param name="delta">The time since last frame. (Usually Time.deltaTime) </param>
        public virtual void LogicUpdate(float delta)
        {

        }
        /// <summary>
        /// Processes updates as if they were in Unity's FixedUpdate function.
        /// </summary>
        /// <param name="delta">The time since last physics frame. (Usually Time.fixedDeltaTime) </param>
        public virtual void PhysicsUpdate(float delta)
        {

        }
        /// <summary>
        /// Called when the State is finished executing.
        /// </summary>
        public virtual void Exit()
        {

        }
    }
}
