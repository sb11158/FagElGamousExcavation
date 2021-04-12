using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamousExcavation.Models
{
    public partial class CranialData
    {
        public int CranialDataPk { get; set; }
        public string SampleNumber { get; set; }
        public string MaximumCranialLength { get; set; }
        public string MaximumCranialBreadth { get; set; }
        public string BasionBregmaHeight { get; set; }
        public string BasionNasion { get; set; }
        public string BasionProsthionLength { get; set; }
        public string BizygomaticDiameter { get; set; }
        public string NasionProsthion { get; set; }
        public string MaximumNasalBreadth { get; set; }
        public string InterorbitalBreadth { get; set; }
        public string BurialLocSummary { get; set; }
        public string UniqId { get; set; }
        public string LowPairNs { get; set; }
        public string HighPairNs { get; set; }
        public string BurialPositioningNorthSouthDirection { get; set; }
        public string BurialLocationNs { get; set; }
        public string LowPairEw { get; set; }
        public string HighPairEw { get; set; }
        public string BurialPositioningEastWestDirection { get; set; }
        public string BurialLocationEw { get; set; }
        public string BurialNumber { get; set; }
        public string BurialDepth { get; set; }
        public string BurialSubplot { get; set; }
        public string ArtifactsDescription { get; set; }
        public string ArtifactFound { get; set; }
        public string GilesGender { get; set; }
        public string BodyGender { get; set; }
        public string GenderCode { get; set; }
    }
}
