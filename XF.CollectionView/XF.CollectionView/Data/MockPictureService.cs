using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XF.CollectionView.Models;

namespace XF.CollectionView.Data
{
    public class MockPictureService
    {
        private List<Picture> _pictures;

        public MockPictureService()
        {
            _pictures = new List<Picture>();

            _pictures.Add(new Picture()
            {
                Id = 1,
                 ImageUrl = "https://www.wga.hu/art/a/aachen/rudolf2.jpg",
                 Name = "AACHEN, Hans von",
                 ShortDescription = "Portrait of Emperor Rudolf II\n1590s\nOil on canvas 60 x 48 cm\nKunsthistorisches Museum, Vienna",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/abaquesn/floor2.jpg",
                Name = "ABAQUESNE, Masséot",
                ShortDescription = "Ceramic Floor\n1557\nCeramics\nMusée du Louvre, Paris",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/abaquesn/theflood.jpg",
                Name = "ABAQUESNE, Masséot",
                ShortDescription = "The Flood\nCeramic mural composition\nMusée National de la Renaissance, Écouen",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/abbate/scipio.jpg",
                Name = "ABBATE, Niccolò dell'",
                ShortDescription = "The Continence of Scipio\nc. 1555\nOil on canvas,\n127 x 115 cm\nMusée du Louvre, Paris",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/aldrovan/specimen.jpg",
                Name = "ALDROVANDI, Ulisse",
                ShortDescription = "Specimens of Nature\nWatercolour,\n465 x 360 mm\nBiblioteca,\nUniversity of Bologna, Bologna",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/amigoni/gentlema.jpg",
                Name = "AMIGONI, Jacopo",
                ShortDescription = "Portrait of a Gentlemen in Blue Jacket\nOil on canvas,\n127 x 102 cm\nPrivate collection",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/amigoni/portlady.jpg",
                Name = "AMIGONI, Jacopo",
                ShortDescription = "Portrait of a Lady\nOil on canvas,\n129 x 102 cm\nPrivate collection",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/andrea/castagno/2_famous/3uberti.jpg",
                Name = "ANDREA DEL CASTAGNO",
                ShortDescription = "Famous Persons: Farinata degli Uberti\nc. 1450\nFresco transferred to wood,\n250 x 154 cm\nGalleria degli Uffizi, Florence",
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/anguisso/lucia/selfport.jpg",
                Name = "ANGUISSOLA, Lucia",
                ShortDescription = "Self-Portrait\n1557\nOil on panel,\n28 x 20 cm\nCastello Sforzesco, Milan"
            });

            _pictures.Add(new Picture()
            {
                Id = 1,
                ImageUrl = "https://www.wga.hu/art/a/arellano/11arella.jpg",
                Name = "ARELLANO, Juan de",
                ShortDescription = "Vase of Flower\nOil on canvas,\n62 x 46 cm\nPrivate collection"
            });
        }

        public IEnumerable<Picture> GetAll()
        {
            return _pictures;
        }

        public Picture GetById(int id)
        {
            return _pictures.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
