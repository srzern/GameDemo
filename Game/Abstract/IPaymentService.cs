using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    interface IPaymentService
    {
        void Buy(Customer customer,Games game,Campaign campaign);
    }
}
