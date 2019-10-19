using System;

namespace EventAndDelegatePractice
{
    class ServingFoodService
    {
        public void OnFoodReady(object source, EventArgs args)
        {
            Console.WriteLine("Now Serving food.");
        }
    }

}