using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FagElGamousExcavation.Models
{
    public partial class INDIContext : DbContext
    {
        public INDIContext()
        {
        }

        public INDIContext(DbContextOptions<INDIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllData> AllData { get; set; }
        public virtual DbSet<BioSampleData> BioSampleData { get; set; }
        public virtual DbSet<C14Data> C14Data { get; set; }
        public virtual DbSet<CranialData> CranialData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=aa1t11rvlul533q.ch5ywl5a3rrn.us-east-1.rds.amazonaws.com; Initial Catalog=INDI; User ID=samo;Password=unbreakablepassword;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllData>(entity =>
            {
                entity.HasKey(e => e.UniqId2);

                entity.ToTable("ALL_DATA");

                entity.Property(e => e.UniqId2)
                    .HasColumnName("uniq_id2")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeSkull2018).HasColumnName("age_Skull_2018");

                entity.Property(e => e.AreaHillBurials).HasColumnName("area_hill_burials");

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.ArtifactsDescription).HasColumnName("artifacts_description");

                entity.Property(e => e.BagNum).HasColumnName("bag_num");

                entity.Property(e => e.BasilarSuture).HasColumnName("basilar_suture");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BiologicalInitials).HasColumnName("biological_initials");

                entity.Property(e => e.BiologicalNotes).HasColumnName("biological_notes");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BodyAnalysis).HasColumnName("body_analysis");

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialAgeMethod).HasColumnName("burial_age_method");

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

                entity.Property(e => e.BurialDirection).HasColumnName("burial_direction");

                entity.Property(e => e.BurialGenderMethod).HasColumnName("burial_gender_method");

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.BurialLocSummary).HasColumnName("burial_loc_summary");

                entity.Property(e => e.BurialLocationEw).HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs).HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialPreservation).HasColumnName("burial_preservation");

                entity.Property(e => e.BurialSampleTaken).HasColumnName("burial_sample_taken");

                entity.Property(e => e.BurialSituation).HasColumnName("burial_situation");

                entity.Property(e => e.BurialSubplot).HasColumnName("burial_subplot");

                entity.Property(e => e.ButtonOsteoma).HasColumnName("button_osteoma");

                entity.Property(e => e.ByuSample).HasColumnName("BYU_sample");

                entity.Property(e => e.Calibrated95CalendarDateAvg).HasColumnName("calibrated_95_calendar_date_avg");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Cluster).HasColumnName("cluster");

                entity.Property(e => e.CranialSuture).HasColumnName("cranial_suture");

                entity.Property(e => e.CribraOrbitala).HasColumnName("cribra_orbitala");

                entity.Property(e => e.DateOnSkull).HasColumnName("date_on_skull");

                entity.Property(e => e.DayFound).HasColumnName("day_found");

                entity.Property(e => e.DescriptionOfTaken).HasColumnName("description_of_taken");

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EpiphysealUnion).HasColumnName("epiphyseal_union");

                entity.Property(e => e.EstimateAge).HasColumnName("estimate_age");

                entity.Property(e => e.EstimateAgeGroup).HasColumnName("estimate_age_group");

                entity.Property(e => e.EstimateAgeSingle).HasColumnName("estimate_age_single");

                entity.Property(e => e.EstimateLivingStature).HasColumnName("estimate_living_stature");

                entity.Property(e => e.FaceBundle).HasColumnName("face_bundle");

                entity.Property(e => e.FemurHead).HasColumnName("femur_head");

                entity.Property(e => e.FemurLength).HasColumnName("femur_length");

                entity.Property(e => e.FieldBook).HasColumnName("field_book");

                entity.Property(e => e.FieldBook1).HasColumnName("field_book1");

                entity.Property(e => e.FieldBook2).HasColumnName("field_book2");

                entity.Property(e => e.FieldBook3).HasColumnName("field_book3");

                entity.Property(e => e.FieldBook32).HasColumnName("field_book3_2");

                entity.Property(e => e.FieldBook4).HasColumnName("field_book4");

                entity.Property(e => e.FieldBook5).HasColumnName("field_book5");

                entity.Property(e => e.FieldBook6).HasColumnName("field_book6");

                entity.Property(e => e.FieldBook7).HasColumnName("field_book7");

                entity.Property(e => e.FieldBook8).HasColumnName("field_book8");

                entity.Property(e => e.FieldBookPageNumber).HasColumnName("field_book_page_number");

                entity.Property(e => e.ForemanMagnum).HasColumnName("foreman_magnum");

                entity.Property(e => e.GeFunctionTotal).HasColumnName("GE_function_total");

                entity.Property(e => e.GenderBodyCol).HasColumnName("gender_body_col");

                entity.Property(e => e.GenderCode).HasColumnName("gender_code");

                entity.Property(e => e.GenderGe).HasColumnName("gender_GE");

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.Goods).HasColumnName("goods");

                entity.Property(e => e.HairColor).HasColumnName("hair_color");

                entity.Property(e => e.HairColorCode).HasColumnName("hair_color_code");

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection).HasColumnName("head_direction");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.HumerusHead).HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength).HasColumnName("humerus_length");

                entity.Property(e => e.InitialsOfDataEntryChecker).HasColumnName("initials_of_data_entry_checker");

                entity.Property(e => e.InitialsOfDataEntryExpert).HasColumnName("initials_of_data_entry_expert");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.LengthOfBurialCm).HasColumnName("length_of_burial_cm");

                entity.Property(e => e.LinearHypoplasiaEnamel).HasColumnName("linear_hypoplasia_enamel");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_IP_ramus");

                entity.Property(e => e.MetopicSuture).HasColumnName("metopic_suture");

                entity.Property(e => e.MonthFound).HasColumnName("month_found");

                entity.Property(e => e.MonthOnSkull).HasColumnName("month_on_skull");

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion_prosthion");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.OsteologyNotes).HasColumnName("osteology_notes");

                entity.Property(e => e.OsteologyUnknownComment).HasColumnName("osteology_unknown_comment");

                entity.Property(e => e.Osteophytosis).HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies).HasColumnName("pathology_anomalies");

                entity.Property(e => e.PoroticHyperostosis).HasColumnName("porotic_hyperostosis");

                entity.Property(e => e.PoroticHyperostosisLocations).HasColumnName("porotic_hyperostosis_LOCATIONS");

                entity.Property(e => e.PostcraniaAtMagazine).HasColumnName("postcrania_at_magazine");

                entity.Property(e => e.PostcraniaTrauma).HasColumnName("postcrania_trauma");

                entity.Property(e => e.PostcraniaTrauma2).HasColumnName("postcrania_trauma2");

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex).HasColumnName("preservation_index");

                entity.Property(e => e.PreviouslySampled).HasColumnName("previously_sampled");

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis).HasColumnName("pubic_symphysis");

                entity.Property(e => e.Questions).HasColumnName("questions");

                entity.Property(e => e.RackAndShelf).HasColumnName("rack_and_shelf");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SexSkull2018).HasColumnName("sex_Skull_2018");

                entity.Property(e => e.SkullAtMagazine).HasColumnName("skull_at_magazine");

                entity.Property(e => e.SkullTrauma).HasColumnName("skull_trauma");

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet).HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead).HasColumnName("south_to_head");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TemporalMandibularJointOsteoarthritisTmjOa).HasColumnName("temporal_mandibular_joint_osteoarthritis_TMJ_OA");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength).HasColumnName("tibia_length");

                entity.Property(e => e.ToBeConfirmed).HasColumnName("TO_BE_CONFIRMED");

                entity.Property(e => e.TombBurial).HasColumnName("tomb_burial");

                entity.Property(e => e.ToothAttrition).HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption).HasColumnName("tooth_eruption");

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.UniqId).HasColumnName("uniq_id");

                entity.Property(e => e.UnknownColSorted).HasColumnName("unknown_col_sorted");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.WestToFeet).HasColumnName("west_to_feet");

                entity.Property(e => e.WestToHead).HasColumnName("west_to_head");

                entity.Property(e => e.YearFound).HasColumnName("year_found");

                entity.Property(e => e.YearOnSkull).HasColumnName("year_on_skull");

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            modelBuilder.Entity<BioSampleData>(entity =>
            {
                entity.HasKey(e => e.BioSamplePk2);

                entity.ToTable("BIO_SAMPLE_DATA");

                entity.Property(e => e.BioSamplePk2)
                    .HasColumnName("bio_sample_pk2")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.BagNum).HasColumnName("bag_num");

                entity.Property(e => e.BioSamplePk).HasColumnName("bio_sample_pk");

                entity.Property(e => e.BiologicalInitials).HasColumnName("biological_initials");

                entity.Property(e => e.BiologicalNotes).HasColumnName("biological_notes");

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.BurialLocSummary).HasColumnName("burial_loc_summary");

                entity.Property(e => e.BurialLocationEw).HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs).HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSubplot).HasColumnName("burial_subplot");

                entity.Property(e => e.Cluster).HasColumnName("cluster");

                entity.Property(e => e.Column21).HasColumnName("column21");

                entity.Property(e => e.DateFound).HasColumnName("date_found");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.PreviouslySampled).HasColumnName("previously_sampled");

                entity.Property(e => e.YearFound).HasColumnName("year_found");
            });

            modelBuilder.Entity<C14Data>(entity =>
            {
                entity.HasKey(e => e.C14Pk2);

                entity.ToTable("C14_DATA");

                entity.Property(e => e.C14Pk2)
                    .HasColumnName("c14_pk2")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.BurialLocSummary).HasColumnName("burial_loc_summary");

                entity.Property(e => e.BurialLocationEw).HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs).HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSubplot).HasColumnName("burial_subplot");

                entity.Property(e => e.C14Pk).HasColumnName("c14_pk");

                entity.Property(e => e.C14Sample2017).HasColumnName("c14_sample_2017");

                entity.Property(e => e.Calibrated95CalendarDateAvg).HasColumnName("calibrated_95_calendar_date_avg");

                entity.Property(e => e.Calibrated95CalendarDateMax).HasColumnName("calibrated_95_calendar_date_max");

                entity.Property(e => e.Calibrated95CalendarDateMin).HasColumnName("calibrated_95_calendar_date_min");

                entity.Property(e => e.Calibrated95CalendarDateSpan).HasColumnName("calibrated_95_calendar_date_span");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Column25).HasColumnName("column25");

                entity.Property(e => e.Column33).HasColumnName("column33");

                entity.Property(e => e.Conventional14cAgeBp).HasColumnName("Conventional_14C_age_BP");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Foci).HasColumnName("foci");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Questions).HasColumnName("questions");

                entity.Property(e => e.Rack2).HasColumnName("rack2");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.TubeNumber).HasColumnName("tube_number");

                entity.Property(e => e.UniqId).HasColumnName("uniq_id");

                entity.Property(e => e._14cCalendarDate).HasColumnName("_14C_calendar_date");
            });

            modelBuilder.Entity<CranialData>(entity =>
            {
                entity.HasKey(e => e.CranialDataPk);

                entity.ToTable("CRANIAL_DATA");

                entity.Property(e => e.CranialDataPk)
                    .HasColumnName("cranial_data_pk")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.ArtifactsDescription).HasColumnName("artifacts_description");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BodyGender).HasColumnName("body_gender");

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

                entity.Property(e => e.BurialLocSummary).HasColumnName("burial_loc_summary");

                entity.Property(e => e.BurialLocationEw).HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs).HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialPositioningEastWestDirection).HasColumnName("burial_positioning_east_west_direction");

                entity.Property(e => e.BurialPositioningNorthSouthDirection).HasColumnName("burial_positioning_north_south_direction");

                entity.Property(e => e.BurialSubplot).HasColumnName("burial_subplot");

                entity.Property(e => e.GenderCode).HasColumnName("gender_code");

                entity.Property(e => e.GilesGender).HasColumnName("giles_gender");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion_prosthion");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.UniqId).HasColumnName("uniq_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
