using LR7_s8.DBCon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR7_s8.DBCon;

namespace LR7_s8.BuilderBurger
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burgers _burger;

        IBurgerBuilder IBurgerBuilder.AddBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddCheees()
        {
            _burger.Cheese = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddPickles()
        {
            _burger.Pickles = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }
        public Burgers GetBurgers()
        {
            Burgers burger = _burger;
            _burger = new Burgers();
            return burger;
        }
    }
}
