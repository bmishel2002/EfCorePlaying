using System;
using System.Collections.Generic;
using System.Text;

namespace EfCorePlaying
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    namespace Intro
    {
        public class BloggingContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseSqlServer(@"Server = (local); Database = EfCoreDb; User Id = BaseTrade; Password = 1q2w3e4r+;");

                //optionsBuilder.UseSqlServer("Data Source=BaseTrade;initial catalog=EfCoreDb;Integrated Security=false;uid=BaseTrade;password=1q2w3e4r+;");
            }
        }

        public class Blog
        {
            public int BlogId { get; set; }
            public string Url { get; set; }
            public int Rating { get; set; }
            public int EsitimateReadInMinutes { get; set; }
            public List<Post> Posts { get; set; }
        }

        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int BlogId { get; set; }
            public Blog Blog { get; set; }
        }
    }
}
