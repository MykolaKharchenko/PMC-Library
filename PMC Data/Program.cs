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

    abstract class Page
    {
    }
    class SkillsPage : Page
    {
    }
    class EducationPage : Page
    {
    }
    class ExperiencePage : Page
    {
    }
    class IntroductionPage : Page
    {
    }
    class ResultsPage : Page
    {
    }
    class ConclusionPage : Page
    {
    }
    class SummaryPage : Page
    {
    }
    class BibliographyPage : Page
    {
    }
    abstract class Document
    {
        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages { get; } = new List<Page>();

        public abstract void CreatePages();
    }
    class Resume : Document
    {        
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
    /*
      Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();
            
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }            
            Console.ReadKey();
      */
}
