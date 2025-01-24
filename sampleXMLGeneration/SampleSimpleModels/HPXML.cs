using System.Xml.Serialization;

namespace sampleXMLGeneration.SampleSimpleModels
{
    [XmlRoot("HPXML", Namespace = "http://hpxmlonline.com/2023/09")]
    public class HPXML
    {
        [XmlAttribute("schemaVersion")]
        public string SchemaVersion { get; set; }

        public XMLTransactionHeaderInformation XMLTransactionHeaderInformation { get; set; }
        public SoftwareInfo SoftwareInfo { get; set; }
        public Building Building { get; set; }
    }

    public class XMLTransactionHeaderInformation
    {
        public string XMLType { get; set; }
        public string XMLGeneratedBy { get; set; }
        public DateTime CreatedDateAndTime { get; set; }
        public string Transaction { get; set; }
    }

    public class SoftwareInfo
    {
        public string SoftwareProgramUsed { get; set; }
        public string SoftwareProgramVersion { get; set; }
    }

    public class Building
    {
        [XmlElement("BuildingID")]
        public BuildingID BuildingID { get; set; }

        public Site Site { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public BuildingDetails BuildingDetails { get; set; }
    }

    public class BuildingID
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
    }

    public class Site
    {
        [XmlElement("SiteID")]
        public SiteID SiteID { get; set; }

        public Address Address { get; set; }
    }

    public class SiteID
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
    }

    public class Address
    {
        public string AddressType { get; set; }
        public string Address1 { get; set; }
        public string CityMunicipality { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
    }

    public class ProjectStatus
    {
        public string EventType { get; set; }
        public DateTime Date { get; set; }
    }

    public class BuildingDetails
    {
        public BuildingSummary BuildingSummary { get; set; }
    }

    public class BuildingSummary
    {
        public BuildingConstruction BuildingConstruction { get; set; }
    }

    public class BuildingConstruction
    {
        public string ResidentialFacilityType { get; set; }
    }
}
