using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR7_s8.BuilderBurger;

namespace LR7_s8.BuilderBurger
{
    internal class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }
        public void BuildDefault()
        {
            _builder
            .AddCheees()
            .AddTomato()
            .AddPickles();
        }
        public void BuildWithBeacon()
        {
            _builder
            .AddTomato()
            .AddBacon()
            .AddLetuce();
        }
    }
}
