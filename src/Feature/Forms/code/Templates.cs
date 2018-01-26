﻿using Sitecore.Data;     

namespace Sitecore.Feature.Forms
{
    public struct Templates
    {
        public struct PatternCardActionSettings
        {
            public static readonly ID ID = new ID("{5996AE17-2739-49F0-A1C8-C5EDBE3F0025}");

            public struct Fields
            {
                public static readonly ID FormQuestion = new ID("{8C512534-BA02-49FC-91BE-66DA6E6AA1B6}");
            }
        }

        public struct PatternCardActionMapping
        {
            public static readonly ID ID = new ID("{4FDED342-B304-42F7-8091-AE3EB660BA4C}");

            public struct Fields
            {
                public static readonly ID PatternCard = new ID("{E30632B3-B1C5-494E-8EB2-5C323FE80C5E}");
                public static readonly ID MappedValue = new ID("{ECB328C3-8F41-4C0B-8FDF-A01096146F3B}");
            }
        }
    }
}