﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc1.Data;
using SalesWebMvc1.Models;

namespace SalesWebMvc1.Services
{
    public class SellerSevice
    {
        private readonly SalesWebMvc1Context _context;

        public SellerSevice(SalesWebMvc1Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
