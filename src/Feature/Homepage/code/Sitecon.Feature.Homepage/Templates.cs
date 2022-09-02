using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Homepage
{
    public static class Templates
    {
        public static class HomepageTwoColumnCTA
        {
            public static class Fields
            {
                public static readonly ID Column1Title = new ID("{8E2F8E4B-EB2A-454D-AA6C-511F450A2083}");
                public static readonly ID Column1Text = new ID("{450111BD-DACA-453D-91BE-61B9205FB202}");
                public static readonly ID Column1Link = new ID("{E1919AD1-839D-43FF-AB85-301DC2BB8000}");
                public static readonly ID Column1Image = new ID("{70275A3F-72F8-48AB-AD86-F09521284252}");
                public static readonly ID Column2Title = new ID("{0B5F37C5-9FDC-470C-B9C6-709886646FC8}");
                public static readonly ID Column2Text = new ID("{77BD0CC3-E984-44E1-A440-5CF11049E344}");
                public static readonly ID Column2Link = new ID("{D5B967D8-B08D-49B6-9F8D-A8FF12F91845}");
                public static readonly ID Column2Image = new ID("{99B4541F-407C-4894-9AD1-C20AC578FD0A}");
            }
        }

        public static class HomepageCTA
        {
            public static class Fields
            {
                public static readonly ID CTABackgroundImage = new ID("{10EB2BEB-DB61-4DC0-B87F-83BAA191CC9B}");
                public static readonly ID CTATitle = new ID("{6CD4013F-F765-47CA-ABB1-AF89B6710E5A}");
                public static readonly ID CTAText = new ID("{B0164DB1-A4FB-4468-907C-483CB804C7C0}");
                public static readonly ID CTALink = new ID("{58D9E6C8-0C77-45F2-B30B-412793276585}");
            }
        }

        public static class HomepageHero
        {
            public static class Fields
            {
                public static readonly ID HomepageHeroBackgroundImage = new ID("{15521297-5F20-43EF-92F8-7E4895C660EA}");
                public static readonly ID HomepageHeroTagline = new ID("{B1C0E41F-A99E-4F84-8EA3-86E439591BFD}");
                public static readonly ID HomepageHeroTitle = new ID("{780ED79F-4AAC-4D7B-B593-59D321387F19}");
                public static readonly ID HomepageHeroSubtitle = new ID("{77FD9B34-3550-4106-8525-9FC215752E46}");
                public static readonly ID HomepageHeroCTALink = new ID("{85B9134E-DB5C-4E04-AB36-35B0489C226E}");
                public static readonly ID HomepageHeroCTALinkText = new ID("{532D99FA-3283-4368-ADE0-66CB0FECF087}");
            }
        }
    }
}