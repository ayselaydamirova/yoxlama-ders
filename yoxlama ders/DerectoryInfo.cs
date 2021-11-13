using System;

namespace yoxlama_ders
{
    internal class DerectoryInfo
    {
        private string path;

        public DerectoryInfo(string path)
        {
            this.path = path;
        }

        public bool Exists { get; internal set; }
        public bool Name { get; internal set; }
        public bool FullName { get; internal set; }
        public bool CreatioanTime { get; internal set; }

        internal void Delete()
        {
            throw new NotImplementedException();
        }

        public bool LastAccessTime { get; internal set; }
        public bool LastWriteTime { get; internal set; }
    }
}