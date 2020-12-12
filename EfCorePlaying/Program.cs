using EfCorePlaying.Intro;
using System;
using System.Threading.Tasks;

namespace EfCorePlaying
{
    class Program
    {
        static async Task Main(string[] args)
        {

            using (var db = new BloggingContext())
            {
                 await db.Blogs.AddAsync(new Blog
                {
                    Url = "http:/someurl",
                    Rating = 2
                    
                }); ;
                
                 await db.SaveChangesAsync();
               
            }


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        
        }
    }
}
