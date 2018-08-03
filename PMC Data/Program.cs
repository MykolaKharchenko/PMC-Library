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
            {
                ContainersCreator[] cc = new ContainersCreator[2];

                cc[0] = new ContainersIntCreator();
                cc[1] = new ContainersDecimalCreator();

                cc[0].AddItem(new Container<int>());


                foreach (var item in cc)
                {
                    item.AddItem(new Container<int>());         //  ага, не работает , это хорошо
                }
                return;
            }

            {

                var pos1 = new Position<float>();
                var pos2 = new Position<int>();

                var mtrx1 = new Matrix<float>();
                mtrx1.AddItem(pos1);
                //mtrx1.AddItem(pos2);

                var pnt1 = new Point<decimal>(3, 5);
                var pnt2 = new Point<decimal>(36, 54, 564564);
                var position1 = new Position<decimal>(pnt1, pnt2);

                var m1 = new Matrix<decimal>(position1);
                var cntr1 = new Container<decimal>(m1);
                var cntrs1 = new Containers<int>();
                //cntrs1.AddItem(cntr1);

            }   // test 

            Console.ReadKey();
        }
    }
}
