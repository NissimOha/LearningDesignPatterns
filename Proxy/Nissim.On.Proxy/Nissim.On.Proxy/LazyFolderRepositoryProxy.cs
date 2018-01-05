using System;

namespace Nissim.On.Proxy
{
    /// <summary>
    /// Lazy action in the Get method (using proxy).
    /// </summary>
    class LazyFolderRepositoryProxy : IFolderRepository
    {
        public LazyFolderRepositoryProxy(string p_path)
        {
            m_path = p_path;
        }

        public int GetNumberOfLines()
        {
            if(m_realFileRepository != null)
            {
                m_realFileRepository = new RealFolderRepository(m_path);
            }

            return m_realFileRepository.GetNumberOfLines();
        }

        public bool IsExist()
        {
            if (m_realFileRepository == null)
            {
                m_realFileRepository = new RealFolderRepository(m_path);
            }

            return m_realFileRepository.IsExist();
        }

        private RealFolderRepository m_realFileRepository;
        private readonly string m_path;
    }
}
