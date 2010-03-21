using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

using ClassLibrary1;

namespace ConsoleApplication1
{
    public class Program
    {
        [Import(typeof (IContract))]
        private readonly IList<IContract> contracts;

        public Program()
        {
            contracts = new List<IContract>();
        }

        private static void Main()
        {
            var p = new Program();
            var catalogs = new AssemblyCatalog(typeof(Program).Assembly);
            
            new Composer(p, ".", catalogs)
                .Compose();

            p.WriteNames();

            Console.ReadLine();
        }

        private void WriteNames()
        {
            Console.Out.WriteLine("Names: ");
            foreach (IContract list in contracts)
            {
                Console.Out.WriteLine("GetName() = {0}", list.GetName());
            }
        }
    }
}