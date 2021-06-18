﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo.Models
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options): base(options) { 
        
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
