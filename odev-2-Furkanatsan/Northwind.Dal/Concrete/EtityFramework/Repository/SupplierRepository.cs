﻿using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EtityFramework.Repository
{
    public class SupplierRepository:GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(DbContext context):base(context)
        {

        }
    }
}