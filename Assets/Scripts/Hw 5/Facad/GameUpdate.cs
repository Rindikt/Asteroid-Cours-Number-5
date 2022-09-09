using System.Collections.Generic;


namespace Asteroid
{
    internal class GameUpdate
    {
        private List<IExecute> _executes = new List<IExecute>();

        public void Execute()
        {
            if (_executes!=null)
            {
                foreach (var item in _executes)
                {
                    item.Execute();
                }
            }

        }
        public void AddListExecute(IExecute execute)
        {
            _executes.Add(execute);
        }
    }
}
