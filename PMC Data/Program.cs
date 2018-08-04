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
            var pt1 = new Pnt<int>(56);
            var pt2 = new Pnt<int>(5, 88);
            var pt3 = new Pnt<int>(235, 6, 45);


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

            var xx2 = new Matrix<int>();
            xx2.AddItem(new Position<int>(new Point<int>(5, 6), new Point<int>()));
            var sss = new Point<int>(5, 5, 6);

            Matrix<int> mtrx1 = new Matrix<int>();
            mtrx1.AddItem(new Position<int>());
            mtrx1.AddItem(new Position<int>());

            Console.ReadKey();
        }
    }
}