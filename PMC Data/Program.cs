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
                var xx2 = new Matrix<int>();

                xx2.AddItem(new Position<int>( new Point<int>(5, 6), new Point<int>()));


                var s = new List<string>();

                var sss = new Point<int>(5, 5, 6);
                sss.GetType();

                Matrix<int> mtrx1 = new Matrix<int>();
                mtrx1.AddItem(new Position<int>());
                mtrx1.AddItem(new Position<int>());

                Console.ReadKey();

                ContainersCreator[] cntrsArr = new ContainersCreator[4];

                cntrsArr[0] = new ContainersIntCreator();
                cntrsArr[1] = new ContainersDecimalCreator();
                cntrsArr[2] = new ContainersDoubleCreator();
                cntrsArr[3] = new ContainersIntCreator();

                foreach (var cntrs in cntrsArr)
                {
                    foreach (var item in cntrs.ContainersArr)
                    {
                        Console.WriteLine(item.GetType());
                    }
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