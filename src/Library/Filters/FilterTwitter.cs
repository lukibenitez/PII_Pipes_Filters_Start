using System;
using System.Drawing;
using CompAndDel;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture picture)
        {
            picTwitter(picture);
            return picture;
        }
        public void picTwitter(IPicture picture)
        {
            TwitterImage picture2 = new TwitterImage();
            Console.WriteLine(picture2.PublishToTwitter("prueba", @"pictureSave.jpg"));
        }
    }
}