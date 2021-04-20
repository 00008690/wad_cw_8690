using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD._8690.APP.Models.Builders
{
    public interface IBuilder
    {
        void SetPrice();
        void SetDeliveredTime();
        void SetName();
        void SetAmount();
        void SetBasePrice();
        void SetSoldPrice();
        void SetExpireDate();
        void SetBuyer();
        void SetDiscount();
    }
}
