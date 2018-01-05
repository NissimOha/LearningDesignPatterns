using Nissim.On.TemplateMethod.ConcretePosters;

namespace Nissim.On.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Poster firstCv = new CvOne();
            Poster secondCv = new CvTwo();
            
            //firstCv.PosterPattern();
            secondCv.PosterPattern();
        }
    }
}
