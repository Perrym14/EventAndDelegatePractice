using System;

namespace EventAndDelegatePractice
{
    class ServingFoodService
    {
        public void OnFoodReadyToBeServed(object source, EventArgs args)
        {
            Console.WriteLine("Now Serving food.");
        }
    }

}