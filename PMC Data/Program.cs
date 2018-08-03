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
            var pnt1 = new Point<int>(3, 5);
            var pnt2 = new Point<decimal>(36, 54,564564);
            var position1 = new Position(pnt1, pnt2);

            var m1 = new Matrix(position1);
            var cntr1 = new Container<int>(m1);
            var cntrs1 = new Containers<int>();
            cntrs1.AddItem(cntr1);
            //cntrs1.AddItem(position1);

            return;

            ContainersCreator[] cc = new ContainersCreator[2];

            cc[0] = new ContainersIntCreator();
            cc[1] = new ContainersDecimalCreator();

            cc[0].AddItem(new Container<int>());
            

            foreach (var item in cc)
            {
                item.AddItem(new Container<int>());         //  ага, не работает , это хорошо
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
