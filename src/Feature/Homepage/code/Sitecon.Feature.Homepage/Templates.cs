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
                public static readonly ID CTABackgroundImage = new ID("{74BE8A5A-9018-4EFA-B3C8-175D0B75FE55}");
                public static readonly ID CTATitle = new ID("{D1A19ABA-8488-4FF2-9432-1FF42F96A333}");
                public static readonly ID CTAText = new ID("{B5FA4118-83FD-48E7-AA0E-D2EE69AD9136}");
                public static readonly ID CTALink = new ID("{2740BFD4-6E0D-4099-A044-B29D6EF2C3DF}");
            }
        }

        public static class HomepageHero
        {
            public static class Fields
            {
                public static readonly ID HomepageHeroBackgroundImage = new ID("{372D4EEF-4FE2-4040-B52B-28ED912AB099}");
                public static readonly ID HomepageHeroTagline = new ID("{A2C27361-C25E-4BFB-95AE-5C831455C06B}");
                public static readonly ID HomepageHeroTitle = new ID("{2B780F4A-E72B-44BC-ABD4-683532B83DDD}");
                public static readonly ID HomepageHeroSubtitle = new ID("{CFAD1589-35EF-47E1-940C-F04D1BC00ED9}");
                public static readonly ID HomepageHeroCTALink = new ID("{48B24967-7AE3-48BE-BC6E-D2415D4797FF}");
                public static readonly ID HomepageHeroCTALinkText = new ID("{D6B08588-FFBB-400D-BC84-854D48432AE9}");
            }
        }
    }
}