using System;

namespace EventAndDelegatePractice
{
    class FoodRetrievalService
    {
        public void OnFoodReady(object source, EventArgs args)
        {
            Console.WriteLine("Retrieving food.");
        }
    }
}