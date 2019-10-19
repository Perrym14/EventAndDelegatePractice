using System;

namespace EventAndDelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new FoodServer();
            var foodRetrievalService = new FoodRetrievalService();
            var servingFoodService = new ServingFoodService();

            server.FoodReady += foodRetrievalService.OnFoodReadyToBeServed;
            server.FoodReady += servingFoodService.OnFoodReadyToBeServed;

            server.Serve();
        }
    }
}
