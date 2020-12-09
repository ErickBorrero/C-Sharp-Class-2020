using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AutoLot.DAL.efStructures
{
 public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
 {
     public ApplicationDbContextFactory CreateDbCOntext(string[] args)
     {
         var optionsBuilder = new DbCOntextOptionsBuiler<ApplicationDbContextFactory>();

         var connectionString = @"server=.,5433;Database=AutoLotFinal;User Id=sa;Password=P@sswOrd;";

         optionsBuilder.UseSqlServer(connectionString);

         System.Console.WriteLine(connectionString);

         return new ApplicationDbContextz(optionsBuilder.Options);
     }
 }
}
