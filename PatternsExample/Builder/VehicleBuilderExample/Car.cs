using System.Text;
using Newtonsoft.Json;

namespace PatternsExample.Builder.VehicleBuilderExample;

public sealed class Car
{
    public string CarType { get; }
    
    private Dictionary<string, string> _parts = new Dictionary<string, string>();

    public Car(string carType)
    {
        CarType = carType;
    }

    public string this[string key]
    {
        get => _parts[key];
        set => _parts[key] = value;
    }
    
    public string Show()
    {
        // StringBuilder sb = new StringBuilder();
        // foreach (var keyValue in _parts)
        // {
        //     sb.Append($"{keyValue.Key}: {keyValue.Value}");
        // }
        //
        // return sb.ToString();
        
        return JsonConvert.SerializeObject(_parts);
    }
}