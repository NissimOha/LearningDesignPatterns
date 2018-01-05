using System;

namespace Nissim.On.TemplateMethod.ConcretePosters
{
    class CvTwo : Poster
    {
        public override void TextOnPoster()
        {
            for (var i = 0; i < 50; i++)
                System.Console.WriteLine(i + "\tSome discreption....:\t" + i * i);
        }

        public override void AllRightsReserved()
        {
            Console.WriteLine("Nissim Ohayon");
        }
    }
}
