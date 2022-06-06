using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");

            IPipe pipeNull = new PipeNull();
            
            IFilter filterTwitter = new FilterTwitter();
            IPipe PipeSerial4 = new PipeSerial(filterTwitter, pipeNull);

            IFilter filterNegative = new FilterNegative();
            IPipe PipeSerial3 = new PipeSerial(filterNegative, PipeSerial4);

            IFilter filterSave1 = new FilterSave();
            IPipe PipeSerial2 = new PipeSerial(filterSave1, PipeSerial3); 

            IFilter filterGreyscale = new FilterGreyscale();
            IPipe PipeSerial1 = new PipeSerial(filterGreyscale, PipeSerial2);

            IPicture image = PipeSerial1.Send(picture);
            provider.SavePicture(image, @"beerModified.jpg");
        }
    }
}
