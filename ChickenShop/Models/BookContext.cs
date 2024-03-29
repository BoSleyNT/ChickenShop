﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChickenShop.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("ChickensShopOnline")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}