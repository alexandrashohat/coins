using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coinsRepo.Models
{
    public class Taxonomy
    {
        public string Access { get; set; }
        public string FCA { get; set; }
        public string FINMA { get; set; }
        public string Industry { get; set; }
        public string CollateralizedAsset { get; set; }
        public string CollateralizedAssetType { get; set; }
        public string CollateralType { get; set; }
        public string CollateralInfo { get; set; }
    }

    public class Rating
    {
        public Weiss Weiss { get; set; }
    }
    public class Weiss
    {
        public string TechnologyAdoptionRating { get; set; }
        public string MarketPerformanceRating { get; set; }
    }
    public class Data
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int ContentCreatedOn { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string CoinName { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string AssetTokenStatus { get; set; }
        public string Algorithm { get; set; }
        public string ProofType { get; set; }
        public string SortOrder { get; set; }
        public bool Sponsored { get; set; }
        public Taxonomy Taxonomy { get; set; }
        public Rating Rating { get; set; }
        public bool IsTrading { get; set; }
    }
}
