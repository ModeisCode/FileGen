using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGen
{
    public class Album
    {
        AlbumData albumData;

        public Album(AlbumData albumData ) { 
            this.albumData = albumData;
        }


    }

    public struct AlbumData 
    {
        public string name;
        public string description;
        public string albumPath;
        public DateTime? date;
        public string albumState;
        public string? albumBackgroundImagePath;
        public bool star;
        public bool isPrivate;
        public string? password;
    }
}
