using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Events
{
    public static class Templates
    {
        public static class Speaker
        {
            public static class Fields
            {
                public static readonly ID SpeakerName = new ID("{A5C1E9CE-6A15-4953-A3F3-9810A9FA2EF3}");
                public static readonly ID SpeakerTitle = new ID("{8DB8F5E1-20F7-4A4A-B22C-15758F25C2E1}");
                public static readonly ID SpeakerImage = new ID("{508F0684-3EDE-4404-A724-4C5835A759F1}");
                public static readonly ID SpeakerDescription = new ID("{B2FFF077-2FBA-4FB4-A3B5-C91975E8F6CC}");
                public static readonly ID SpeakerTwitterUrl = new ID("{CFF917DD-E47D-4367-8FA6-22324F6D5E07}");
                public static readonly ID SpeakerLinkedInUrl = new ID("{1BDEA8F6-3F2C-4D94-9BCB-4880FC4BFC41}");
                public static readonly ID SpeakerWebsiteUrl = new ID("{F317A726-B96A-4507-8AE5-772965D8A95A}");
            }
        }

        public static class FeaturedSpeaker
        {
            public static class Fields
            {
                public static readonly ID FeaturedSpeakersTitle = new ID("{7D81BA80-3F72-45DF-90F5-7BEF49E9045F}");
                public static readonly ID FeaturedSpeakersText = new ID("{7897ECD5-C389-421B-A8AE-CBD131E835CE}");
                public static readonly ID FeaturedSpeaker = new ID("{E4A37134-9B4A-45E3-9E79-7858E8F4F070}");
                public static readonly ID FeaturedSpeakersList = new ID("{3969C2F3-D13F-4FA5-BB22-FDF6D23EE67B}");
            }
        }

        public static class Event
        {
            public static class Fields
            {
                public static readonly ID EventName = new ID("{08541612-8902-475A-8256-A2608F8BB54A}");
                public static readonly ID EventDate = new ID("{FACA5A9E-B402-4411-8F4E-8052D6FF90B9}");
                public static readonly ID IsFeaturedEvent = new ID("{343C04D5-C3F0-4DFA-9916-A2C2D6C7B70A}");
                public static readonly ID EventSpeakers = new ID("{A6AFFAB7-C46A-4211-A6DE-6C1EBA28A040}");
            }
        }

        public static class EventSchedule
        {
            public static class Fields
            {
                public static readonly ID EventScheduleBackground = new ID("{90D9F377-DC2C-476D-B660-7A655F52F3F4}");
                public static readonly ID EventScheduleTitle = new ID("{4537EDDF-7EF4-44DE-B151-227D9573F3CC}");
                public static readonly ID EventScheduleDay1Title = new ID("{C2E11EEC-5DBF-49A2-ACC2-6B9DA9454600}");
                public static readonly ID EventScheduleDay1Date = new ID("{BF1B2B59-5635-4089-94BF-B81F41D6DB6D}");
                public static readonly ID EventScheduleDay1Location = new ID("{49A2EF9D-89A8-471D-86C6-2F6E69058F50}");
                public static readonly ID EventScheduleDay1Events = new ID("{4C2151CD-B71B-48ED-9104-C64EB30E7D1B}");
                public static readonly ID EventScheduleDay2Title = new ID("{7BD6D186-EF61-4F4A-9E4A-103250A1B415}");
                public static readonly ID EventScheduleDay2Date = new ID("{69C31662-933E-413B-A2F3-FE5F5C18608E}");
                public static readonly ID EventScheduleDay2Location = new ID("{20A5EB6F-5ADE-4EB3-BE6C-444EADE0F65F}");
                public static readonly ID EventScheduleDay2Events = new ID("{8484E3B5-39D7-4A34-9DE3-9D78BBFBE281}");
            }
        }
    }
}