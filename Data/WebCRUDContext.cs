#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Menghi.Massimo._5H.WebCRUD.Models;

    public class WebCRUDContext : DbContext
    {
        public WebCRUDContext (DbContextOptions<WebCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Menghi.Massimo._5H.WebCRUD.Models.Movie> Movie { get; set; }
    }
