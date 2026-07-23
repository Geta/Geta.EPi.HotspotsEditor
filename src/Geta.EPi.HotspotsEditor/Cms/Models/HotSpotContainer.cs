using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using Newtonsoft.Json;

namespace Geta.EPi.HotspotsEditor.Cms.Models
{
    public class HotSpotContainer
    {
        private readonly IContentLoader _contentLoader;
        private IContent _content;

        public HotSpotContainer() : this(ServiceLocator.Current.GetInstance<IContentLoader>())
        { }

        public HotSpotContainer(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public string Link { get; set; }

        [JsonIgnore]
        public IContent Content
        {
            get
            {
                if (_content == null && !string.IsNullOrEmpty(Link) && _content == null && ContentReference.TryParse(Link, out ContentReference contentReference))
                {
                    _contentLoader.TryGet(contentReference, out _content);
                }
                return _content;
            }
        }

        public Rectangle HotSpot { get; set; }

        public FRectangle Area { get; set; }

        public class Rectangle
        {
            public decimal Top { get; set; }

            public decimal Left { get; set; }

            public int Width { get; set; }

            public int Height { get; set; }
        }

        public class FRectangle
        {
            public decimal Top { get; set; }

            public decimal Left { get; set; }

            public decimal Width { get; set; }

            public decimal Height { get; set; }
        }
    }
}
