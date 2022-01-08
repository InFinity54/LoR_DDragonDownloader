using System.Collections.Generic;

namespace LoR_DataDragonDownloader
{
    class Metadata
    {
        public List<string> locales { get; set; }

        public Metadata()
        {
            locales = new List<string>();
        }
    }
}
