using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieTicketPriceCalculator
{
	
    /// <summary>
    /// Wraps a delegate all that is called on Dispose, used for wrapping
    /// an action from a method call that should be invoked on Dispose.
    /// </summary>
    public class DisposableAction : IDisposable
    {
        private readonly Action _action;

        public DisposableAction(Action action)
        {
            _action = action;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _action != null)
            {
                _action();
            }            
        }
    }

}
