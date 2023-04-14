namespace LowLevelDesign.Design_Patterns.Behavioural_Design_Pattern.state_pattern
{
    

// Context class
    class Context
    {
        private State _state;

        public Context(State state)
        {
            _state = state;
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State changed to " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    // State interface
    interface State
    {
        void Handle(Context context);
    }

    // Concrete state classes
    class ConcreteStateA : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handling request in state A.");
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handling request in state B.");
            context.State = new ConcreteStateA();
        }
    }

    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the context and setting the initial state
            Context context = new Context(new ConcreteStateA());

            // Making requests and changing the state
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();
        }
    }

}
