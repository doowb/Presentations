using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lodash.Models
{
    public class Food : IModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Organic { get; set; }

        public static List<IModel> GetAll()
        {
            List<IModel> foods = new List<IModel>();

            foods.Add(new Food { Name = "apple", Organic = true, Type = "fruit" });
            foods.Add(new Food { Name = "banana", Organic = true, Type = "fruit" });
            foods.Add(new Food { Name = "beet", Organic = false, Type = "vegetable" });
            foods.Add(new Food { Name = "carrot", Organic = false, Type = "vegetable" });
            foods.Add(new Food { Name = "orange", Organic = false, Type = "fruit" });

            return foods;
        }
    }
}