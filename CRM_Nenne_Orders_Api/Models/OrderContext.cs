﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRM_Nenne_Orders_Api.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            :base(options)
        {

        }

        public DbSet<Order> Customers { get; set; }
    }
}