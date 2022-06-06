using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        public IPicture Filter(IPicture picture)
        {
            PictureProvider pic = new PictureProvider();
            pic.SavePicture(picture, @"pictureSave.jpg");
            return picture;
        }
    }
}