using LR7_s8.DBCon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_s8.BuilderBurger
{
    internal interface IBurgerBuilder
    {
        IBurgerBuilder AddCheees();
        IBurgerBuilder AddBacon();
        IBurgerBuilder AddLetuce();
        IBurgerBuilder AddTomato();
        IBurgerBuilder AddPickles();
        Burgers GetBurgers();
    }
}
