using EPiServer;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Core;
using EPiServer.ServiceLocation;

namespace Geta.EPi.HotspotsEditor.Cms.Models
{
    public class HotSpotContainer
    {
        private readonly IContentLoader _contentLoader;
        private IContent _content;

        public HotSpotContainer() : this(ServiceLocator.Current.GetInstance<IContentLoader>())
        {}

        public HotSpotContainer(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public string Link { get; set; }

        private void LoadContent()
        {
            if (!string.IsNullOrEmpty(Link) && _content == null)
            {
                ContentReference.TryParse(Link, out ContentReference contentReference);
                _contentLoader.TryGet(contentReference, out _content);
            }
        }

        public EntryContentBase IndexedProduct
        {
            get
            {                
                ContentReference.TryParse(Link, out ContentReference contentReference);
                _contentLoader.TryGet(contentReference, out EntryContentBase entryBase);

                return entryBase;
            }
        }

        public string ProductCode
        {
            get
            {
                ContentReference.TryParse(Link, out ContentReference contentReference);
                _contentLoader.TryGet(contentReference, out EntryContentBase product);

                if (product == null) return string.Empty;

                return product.Code;
            }
        }

        public HotSpot hotSpot { get; set; }
        public HotSpotArea Area { get; set; }

        public class HotSpot
        {
            public decimal Top { get; set; }
            public decimal Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class HotSpotArea
        {
            public decimal Top { get; set; }
            public decimal Left { get; set; }
            public decimal Width { get; set; }
            public decimal Height { get; set; }
        }
    }
}