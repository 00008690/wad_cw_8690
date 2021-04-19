using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD._8690.APP.Models.Builders;

namespace WAD._8690.APP.Models
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildPremiumProduct(Product product)
        {

        }

        public void BuildArrangedProduct(Product product)
        {

        }

        public void BuilCreditProduct(Product product)
        {

        }
    }
}
