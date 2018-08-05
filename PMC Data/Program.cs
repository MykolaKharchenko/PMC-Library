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
using ModelsLib.PointClasses;

namespace PMC_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> pnt1 = new Point3D<int>(5, 67, 2);
            Point<int> pnt2 = new Point1D<int>(255);
            Point<int> pnt3 = new Point2D<int>(61, 12);

            var pos1 = new Position<int>(pnt1, pnt3);
            var pos2 = new Position<int>(pnt1, pnt1, pnt1, pnt1);
            var pos3 = new Position<int>(pnt2);

            var mtrx1 = new Matrix<int>();
            mtrx1.AddItem(pos2);

            var cntr1 = new Container<int>(new Matrix<int>(pos1, pos3));

            var cntrs1 = new Containers<int>(cntr1);


            ContainersCreator[] cntrsArr = new ContainersCreator[4];

            cntrsArr[0] = new ContainersIntCreator();
            cntrsArr[1] = new ContainersDecimalCreator();
            cntrsArr[2] = new ContainersDoubleCreator();
            cntrsArr[3] = new ContainersIntCreator();

        
            Console.ReadKey();
        }
    }
}