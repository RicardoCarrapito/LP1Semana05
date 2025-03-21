using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed=new Random(int.Parse(args[0]));
            Faker faker=new Faker("pt_PT");
            int col=int.Parse(args[0]);

            var table = new Table();
            
            //coluna 
            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name").Centered());
            table.AddColumn(new TableColumn("Job").Centered());

            for(int r=0;r<col;r++)
            {
                string nome =faker.Name.FullName();
                string job =faker.Name.JobArea();
                table.AddRow("sss", nome,job);
            }
           
            

            AnsiConsole.Write(table);

            

        }
        
    }
}



