using Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaleMediator saleMediator = new SaleMediator();

            Artist artist = new Artist(saleMediator);
            RecordStudio recordStudio = new RecordStudio(saleMediator);
            Manager manager = new Manager(saleMediator);
            Album album = new Album(saleMediator);

            saleMediator.Artist = artist;
            saleMediator.Manager = manager;
            saleMediator.RecordStudio = recordStudio;

            album.Sales(100000);
            Console.WriteLine("\n*********\n");
            album.Sales(20000000);
        }
    }
}
