using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id=1, Name="O Cozido", Location = "Marvila", Cuisine = CuisineType.Mexican },
                new Restaurant {Id=2, Name="Caracois", Location = "Lisboa", Cuisine = CuisineType.Indian },
                new Restaurant {Id=3, Name="Pizza", Location = "Odivelas", Cuisine = CuisineType.Italian },
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
