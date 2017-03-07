using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace FrontEnd.Models
{
    public class Beer 
    {
       // public Beer(IGlass glass, ISrm srm, IAvailable available, IStyle style, List<Brewery> breweries, ILabels labels, List<SocialAccount> socialAccounts);

        public double Abv { get; set; }
     //   [JsonConverter(typeof(ConcreteConverter<Available>))]
     //   public IAvailable Available { get; set; }
        public int AvailableId { get; set; }
        public List<Brewery> Breweries { get; set; }
        public string Brewery { get; }
        public string CreateDate { get; set; }
        public string Description { get; set; }
      //  [JsonConverter(typeof(ConcreteConverter<Glass>))]
     //   public IGlass Glass { get; set; }
        public int GlasswareId { get; set; }
        public string Id { get; set; }
        public string IsOrganic { get; set; }
      //  [JsonConverter(typeof(ConcreteConverter<Labels>))]
      //  public ILabels Labels { get; set; }
        public string Name { get; set; }
        public string NameDisplay { get; set; }
        public string ServingTemperature { get; set; }
      //  public List<ISocialAccount> SocialAccounts { get; set; }
      //  [JsonConverter(typeof(ConcreteConverter<Srm>))]
     //   public ISrm Srm { get; set; }
        public int SrmId { get; set; }
        public string Status { get; set; }
        public string StatusDisplay { get; set; }
      //  [JsonConverter(typeof(ConcreteConverter<Style>))]
      //  public IStyle Style { get; set; }
        public int StyleId { get; set; }
        public string UpdateDate { get; set; }
    }


    public class Brewery 
    {
        public string CreateDate { get; set; }
        public string Description { get; set; }
        public string Established { get; set; }
        public string Id { get; set; }
     //   public IImages Image { get; set; }
        public string IsOrganic { get; set; }
      //  public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string StatusDisplay { get; set; }
        public string UpdateDate { get; set; }
        public string Website { get; set; }
    }
}