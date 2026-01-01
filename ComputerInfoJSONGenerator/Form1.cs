using System.Management;
using Newtonsoft.Json;

namespace ComputerInfoJSONGenerator;

public partial class Form1 : Form
{
    
    private readonly Dictionary<string, Dictionary<string, object>> _specs = new();
    private string _json;
    private readonly Dictionary<string, string> _queries = new()
    {
        { "Video Devices", "SELECT DeviceID, VideoProcessor, Name, Description FROM Win32_VideoController" },
        { "RAM",
                "SELECT Tag, BankLabel, Name, Model, OtherIdentifyingInfo, PartNumber, ConfiguredClockSpeed, Speed, Capacity FROM Win32_PhysicalMemory"}, 
        { "Processor", "SELECT DeviceID, Name FROM Win32_Processor" },
        { "Bios Version", "SELECT Name, Manufacturer, IdentificationCode FROM Win32_BIOS" },
        { "Motherboard Information", "SELECT Model, Manufacturer, TotalPhysicalMemory FROM Win32_ComputerSystem" }
    };

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        foreach (KeyValuePair<string, string> query in _queries)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query.Value);
            Dictionary<string, object> jsonObj = new();
            int counter = 0;
            foreach (var o in searcher.Get())
            {
                var queryObj = (ManagementObject)o;
                counter++;
                foreach (var property in queryObj.Properties)
                {
                    jsonObj.Add(property.Name + $"{counter}", queryObj[property.Name]);
                }
            }
            
            _specs.Add(query.Key, jsonObj);
        }
        _json = JsonConvert.SerializeObject(_specs, Formatting.Indented);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string path = @".\specs.json";

        if (File.Exists(path))
        {
            File.Delete(path);
        }

        using (StreamWriter sw = File.CreateText(path))
        {
            sw.Write(_json);
        }
        
        label1.Text = "JSON file has been created! Please check the directory the executable is located for the file.";
        label1.Refresh();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}