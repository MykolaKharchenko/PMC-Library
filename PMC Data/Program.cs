using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib;
using ModelsLib.Interfaces;
using ModelsLib.Collections;
using ModelsLib.ContainersCreating;

namespace PMC_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainersCreator[] cc = new ContainersCreator[2];

            cc[0] = new ContainersDecimalCreator();
            cc[1] = new ContainersIntCreator();
            
            foreach (var item in cc)
            {
                item.AddItem(new Container());
            }

            return;


















            IPoint p1 = new Point<int>(5, 5348, -456);
            IPoint p2 = new Point<decimal>(4);
            IPoint p3 = new Point<double>(7F, 8f);
            Position pos1 = new Position(p1, p1, p2, p3, p3);                                                                 
            pos1.AddItem(pos1._position, p1);
            //pos1.AddItem(p3);
            //pos1.AddItem(p3);
            //pos1.AddItem(p1);
            pos1.RemoveItem(300);

            for (int i = 0; i < pos1.Length; i++)
                Console.WriteLine(pos1[i].ToString() + "\t");
            Console.WriteLine("--------------------------------");
            pos1.RemoveItem(2);
            for (int i = 0; i < pos1.Length; i++)
                Console.WriteLine(pos1[i].ToString() + "\t");

            IPoint p4 = new Point<double>(1, 2.3, 4);
            var mtrx1 = new Matrix();

            //mtrx1.AddItem(pos1);
            //mtrx1.AddItem(pos1);
            //var cntr = new Container();
            //cntr.AddItem(mtrx1);
            //var cntrs1 = new Containers();
            //cntrs1.AddItem(cntr);
            //var cntrs_index = cntrs1[0];

            Console.ReadKey();
        }
    }
}
