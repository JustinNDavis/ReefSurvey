using System;
using System.Data.Entity.Core;

namespace ReefSurvey.Model
{
    public class Surveys
    {
        public int SurveyIndex { get; set; }
        public DateTime Date { get; set; }
        public string Management { get; set; }
        public string batchCode { get; set; }
    }

    public class SurveyDetails
    {
        public int SurveyDetailID { get; set; }
        public int FishID { get; set; }
        public int FishCount { get; set; }
        public int SurveyIndex { get; set; }
    }
    public class LocationDetails
    {
        public int LocationID { get; set; }
        public string SubRegion { get; set; }
        public float LAT { get; set; }
        public float LONG { get; set; }
        public int SurveyIndex { get; set; }
        public string StudyArea { get; set; }
        public string Region { get; set; }
    }

    public class Fish
    {
        public int FishID { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Family { get; set; }
        public float Length { get; set; }
        public char Tophic { get; set; }
        public string StructureType { get; set; }
    }
    public class DiseasedFish
    {
        public int DFid { get; set; }
        public int FishID { get; set; }
        public string Family { get; set; }
        public string PercentCover { get; set; }
        public string DiseasedCover { get; set; }
        public string BleachedCover { get; set; }
        public float Height { get; set; }
        public int Individuals { get; set; }
    }
}
