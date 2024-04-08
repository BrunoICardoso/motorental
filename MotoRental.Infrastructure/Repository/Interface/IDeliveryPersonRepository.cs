﻿using MotoRental.Core.Entity.SchemaCore;
using MotoRental.Infrastructure.Repository.Settings.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoRental.Infrastructure.Repository.Interface
{
    public interface IDeliveryPersonRepository : IDomainRepository<DeliveryPerson>
    {
        Task<IEnumerable<int>> GetEligibleDeliveryPersonsForOrder();
    }
}