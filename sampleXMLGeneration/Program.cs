using System;
using System.IO;
using System.Xml.Serialization;
using sampleXMLGeneration.SampleSimpleModels;

class Program
{
    static void Main(string[] args)
    {
        var hpxml = new HPXML
        {
            SchemaVersion = "4.0",
            XMLTransactionHeaderInformation = new XMLTransactionHeaderInformation
            {
                XMLType = string.Empty,
                XMLGeneratedBy = "VS Code",
                CreatedDateAndTime = DateTime.Parse("2025-01-23T11:40:00"),
                Transaction = "create"
            },
            SoftwareInfo = new SoftwareInfo
            {
                SoftwareProgramUsed = "ID Energy Score Generator",
                SoftwareProgramVersion = "1.0"
            },
            Building = new Building
            {
                BuildingID = new BuildingID { Id = "buildingid-2" },
                Site = new Site
                {
                    SiteID = new SiteID { Id = "siteid-1" },
                    Address = new Address
                    {
                        AddressType = "street",
                        Address1 = "8 API House",
                        CityMunicipality = "Kansas City",
                        StateCode = "KS",
                        ZipCode = "66101"
                    }
                },
                ProjectStatus = new ProjectStatus
                {
                    EventType = "quality assurance/monitoring",
                    Date = DateTime.Parse("2025-01-23")
                },
                BuildingDetails = new BuildingDetails
                {
                    BuildingSummary = new BuildingSummary
                    {
                        BuildingConstruction = new BuildingConstruction
                        {
                            ResidentialFacilityType = "multi-family - condos"
                        }
                    }
                }
            }
        };

        // Determine the project's directory dynamically
        var projectDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"../../../");
        var outputPath = Path.Combine(projectDirectory, "output.xml");

        // Serialize the HPXML object to the file
        var serializer = new XmlSerializer(typeof(HPXML));
        using (var writer = new StreamWriter(outputPath))
        {
            serializer.Serialize(writer, hpxml);
        }

        Console.WriteLine($"Serialization complete. File saved at: {Path.GetFullPath(outputPath)}");
    }
}
