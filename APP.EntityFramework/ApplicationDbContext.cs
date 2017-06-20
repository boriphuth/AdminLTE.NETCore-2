using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using APP.Core.Entities;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace APP.EntityFramework
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
　　　　　　: base(options)
　　　　　　{
        }
        /// <summary>
        /// TODO 在下面添加实体
        /// </summary>
        public   DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
         {
             base.OnModelCreating(builder);
         }
     
    }
}
