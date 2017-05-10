﻿
using Nop.Core.Configuration;

namespace Nop.Plugin.Widgets.NivoSlider
{
    public class NivoSliderSettings : ISettings
    {
        public int Picture1Id { get; set; }
        public string Text1 { get; set; }
        public string Link1 { get; set; }

        public int Picture2Id { get; set; }
        public string Text2 { get; set; }
        public string Link2 { get; set; }

        public int Picture3Id { get; set; }
        public string Text3 { get; set; }
        public string Link3 { get; set; }

        public int Picture4Id { get; set; }
        public string Text4 { get; set; }
        public string Link4 { get; set; }

        public int Picture5Id { get; set; }
        public string Text5 { get; set; }
        public string Link5 { get; set; }

        //Task-4 start
        public int Picture6Id { get; set; }
        public string Text6 { get; set; }
        public string Link6 { get; set; }
                
        public int Picture7Id { get; set; }
        public string Text7 { get; set; }
        public string Link7 { get; set; }
        //Task-4 End

    }
}