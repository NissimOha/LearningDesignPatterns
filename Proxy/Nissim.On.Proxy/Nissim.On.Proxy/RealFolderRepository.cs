using System;
using System.IO;

namespace Nissim.On.Proxy
{
    /// <summary>
    /// Lazy action in the constructor (without using proxy).
    /// </summary>
    class RealFolderRepository : IFolderRepository
    {
        public RealFolderRepository(string p_path)
        {
            m_path = p_path;

            if (!IsExist())
            {
                Console.WriteLine("Folder not exist.");
                return;
            }

            var files = Directory.GetFiles(p_path, ".txt", SearchOption.AllDirectories);

            foreach(var file in files)
            {
                m_numberOfLines += File.ReadAllLines(file).Length;
            }
        }

        public int GetNumberOfLines()
        {
            return m_numberOfLines;
        }

        public bool IsExist()
        {
            return Directory.Exists(m_path);
        }

        private readonly string m_path;
        private readonly int m_numberOfLines;
    }
}
