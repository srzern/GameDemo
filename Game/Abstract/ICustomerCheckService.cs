﻿using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ICustomerCheckService
    {
        void CheckCustomerIsReal(Customer customer);
    }
}
