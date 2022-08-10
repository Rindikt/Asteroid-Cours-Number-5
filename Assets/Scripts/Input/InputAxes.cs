
namespace Asteroid
{
    internal sealed class InputAxes : IExecute
    {
        private InputHorizontal _inputHorizontal;
        private InputVertical _inputVertical;

        public InputVertical InputVertical
        {
            get { return _inputVertical; }
        }
        public InputHorizontal InputHorizontal 
        { 
            get { return _inputHorizontal; } 
        }
        public InputAxes()
        {
            _inputHorizontal = new InputHorizontal();
            _inputVertical = new InputVertical();
        }

        public void Execute()
        {
            _inputHorizontal.GetAxis();
            _inputVertical.GetAxis();
        }
    }
}
