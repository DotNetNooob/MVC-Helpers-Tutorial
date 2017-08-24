using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Helpers_Tutorial
{
    public class CardType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageId { get; set; }
    }

    public class RootObject
    {
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public string Details { get; set; }
        public bool Enabled { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public object TermsAndConditions { get; set; }
        public int TenantId { get; set; }
        public int ImageId { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public List<object> Channels { get; set; }
        public List<CardType> CardTypes { get; set; }
        public List<int> Categories { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsLiked { get; set; }
        public List<object> Tags { get; set; }
    }
}