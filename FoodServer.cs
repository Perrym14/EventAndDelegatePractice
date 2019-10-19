using System;
using System.Threading;

namespace EventAndDelegatePractice
{
    class FoodServer
    {
        //Define delegate.
        //Define an event based on the delegate.
        //Raise the event.

        //Explicitly defining delegate. 
        public delegate void FoodReadyEventHandler(object source, EventArgs args);

        public event FoodReadyEventHandler FoodReady;

        public void Serve()
        {
            Console.WriteLine("Waiting for orders...");
            Thread.Sleep(3000);

            OnFoodReadyToBeServed();
        }

        protected virtual void OnFoodReadyToBeServed()
        {
            FoodReady?.Invoke(this, EventArgs.Empty);
        }
    }
}