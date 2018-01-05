using System.Configuration;

namespace Nissim.On.TemplateMethod
{
    abstract class Poster
    {
        public void PosterPattern()
        {
            DrawImage.DrawImageInConsole(m_title);
            DrawImage.DrawSpace(COLS, ROWS);
            
            TextOnPoster();

            DrawImage.DrawSpace(COLS, ROWS);

            AllRightsReserved();
        }

        /// <summary>
        /// Abstract mehtod : have to be overridden.
        /// </summary>
        public abstract void TextOnPoster();

        /// <summary>
        /// Virtual method : default empty.
        /// </summary>
        public virtual void AllRightsReserved() { }

        private string m_title = ConfigurationManager.AppSettings["TitleImage"];
        private const int COLS = 5;
        private const int ROWS = 100;
    }
}
