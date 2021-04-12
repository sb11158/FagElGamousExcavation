using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamousExcavation.Models
{
    public partial class BioSampleData
    {
        public int BioSamplePk2 { get; set; }
        public string BioSamplePk { get; set; }
        public string BurialId { get; set; }
        public string BurialLocSummary { get; set; }
        public string BagNum { get; set; }
        public string LowPairNs { get; set; }
        public string HighPairNs { get; set; }
        public string BurialLocationNs { get; set; }
        public string LowPairEw { get; set; }
        public string HighPairEw { get; set; }
        public string BurialLocationEw { get; set; }
        public string BurialSubplot { get; set; }
        public string Area { get; set; }
        public string BurialNumber { get; set; }
        public string Cluster { get; set; }
        public string DateFound { get; set; }
        public string YearFound { get; set; }
        public string PreviouslySampled { get; set; }
        public string BiologicalNotes { get; set; }
        public string BiologicalInitials { get; set; }
        public string Column21 { get; set; }
    }
}
