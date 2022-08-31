using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Navigation
{
    public static class Templates
    {
        public static class Header
        {
            public static class Fields
            {
                public static readonly ID Logo = new ID("{105A30CA-2712-401C-8F93-1B7090124E91}");
                public static readonly ID HomeLink = new ID("{AF533E58-4B64-4777-94E5-1FB29212834A}");
                public static readonly ID EventsRoot = new ID("{CF992DA6-DD76-42FF-AF27-78470F8FF185}");
                public static readonly ID ScheduleLink = new ID("{BD7E380E-D285-41A8-BB73-DEA09FC064F4}");
            }
        }

        public static class Footer
        {
            public static class Fields
            {
                public static readonly ID FooterTextLeft = new ID("{FAFC13E1-F674-4B33-9A09-B9EB0494B2E3}");
                public static readonly ID FooterLinkLeft = new ID("{CCC5F7A5-D441-4736-A876-B9BA765AC5BA}");
                public static readonly ID FooterLinkTextLeft = new ID("{0CCFD863-48B2-4090-BEA3-C33BA9A38D09}");
                public static readonly ID FooterTextRight = new ID("{241E5538-1873-4D32-A4C8-6BB0869EAC90}");
                public static readonly ID FooterLinkRight = new ID("{75BD91F9-3BEF-4921-A3B6-9DD161400B15}");
                public static readonly ID FooterLinkTextRight = new ID("{1A440A71-FDD0-4A7F-948F-80C2862C1297}");
            }
        }
    }
}