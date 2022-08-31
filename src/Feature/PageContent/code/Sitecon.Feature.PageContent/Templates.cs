using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.PageContent
{
    public static class Templates
    {
        public static class BodyCopy
        {
            public static class Fields
            {
                public static readonly ID BodyCopy = new ID("{5F10F139-C5CF-4D3A-9A5A-0E7D2BD5E145}");
            }
        }

        public static class TwoImage
        {
            public static class Fields
            {
                public static readonly ID Image1 = new ID("{CF5DA8DA-E196-4C30-A90C-C033D43F6494}");
                public static readonly ID Image2 = new ID("{4B50E06F-7B1A-42C0-819F-D3C433700990}");
            }
        }

        public static class TitleAndText
        {
            public static class Fields
            {
                public static readonly ID ComponentTitle = new ID("{D635B338-BCB6-4A00-BE58-444AB74E3FC1}");
                public static readonly ID ComponentText = new ID("{DAB550DE-93FD-4C1B-8001-5FC7A7B05981}");
            }
        }

        public static class ListWithIcons
        {
            public static class Fields
            {
                public static readonly ID ListIcon = new ID("{AF3DAE1B-C725-4319-A056-3D284437153F}");
                public static readonly ID ListText = new ID("{ABDAD617-FBDC-477E-9CBE-C2603E623890}");
            }
        }

        public static class Hero
        {
            public static class Fields
            {
                public static readonly ID HeroBackgroundImage = new ID("{D8B32A62-7CD4-4AFB-89D6-A3E3A97C4632}");
                public static readonly ID HeroTitle = new ID("{21625D95-4C9E-458C-9436-7588E444A99E}");
                public static readonly ID HeroSubtitle = new ID("{1F7BA84F-C51E-4E00-97BB-6AF81226E099}");
            }
        }

        public static class YouTubeVideo
        {
            public static class Fields
            {
                public static readonly ID YouTubeVideoId = new ID("{DF7F0F3E-CE3A-407E-9F09-30E80C7B98CD}");
            }
        }
    }
}