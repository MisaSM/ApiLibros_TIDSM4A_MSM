using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using P2_MSM_TIDSM4A_U3.Data;
using P2_MSM_TIDSM4A_U3.Data.Models;
using System;
using System.Linq;

namespace P2_TIDSM4A_MSM_U3.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any()) 
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "1st Book Title",
                        Descripcion = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        Autor = "1st Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    },
                    new Book()
                    {
                        Titulo = "2nd Book Title",
                        Descripcion = "2nd Book Description",
                        IsRead = true,
                        Genero = "Biography",
                        Autor = "1st Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    });
                    context.SaveChanges();



                }
            }
        }
    }
}
