using System;
using System.Threading;

namespace EventAndDelegatePractice
{
    class FoodRetrievalService
    {
        public void OnFoodReadyToBeServed(object source, EventArgs args)
        {
            Console.WriteLine("Retrieving food.");
            Thread.Sleep(3000);
        }
    }
}