using System.Configuration;
using System.IO;

namespace Nissim.On.TemplateMethod.ConcretePosters
{
    class CvOne : Poster
    {
        public override void TextOnPoster()
        {
            for (var i = 0; i < 50; i++)
                System.Console.WriteLine(i + "\tSome discreption....:\t" + i * i);
        }
    }
}
