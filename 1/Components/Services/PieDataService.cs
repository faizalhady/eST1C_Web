public class PieDataService
{
    private readonly Dictionary<string, List<MyData>> dataSets = new()
    {
        { "OVERALL", new List<MyData> {
            new MyData { Category = "Sehan", NetProfit = 11 },
            new MyData { Category = "Desoutter", NetProfit = 28 },
            new MyData { Category = "Hantas", NetProfit = 215 }
        }},
        { "ADVANTEST", new List<MyData> {
            new MyData { Category = "Sehan", NetProfit = 11 },
            new MyData { Category = "Desoutter", NetProfit = 3 },
            new MyData { Category = "Hantas", NetProfit = 2 }
        }},
        { "BECKMAN COULTER", new List<MyData> {
            new MyData { Category = "Sehan", NetProfit = 7 },
            new MyData { Category = "Desoutter", NetProfit = 8 },
            new MyData { Category = "Hantas", NetProfit = 9 }
        }}
    };

    public List<MyData> GetData(string key)
    {
        return dataSets.ContainsKey(key) ? dataSets[key] : new List<MyData>();
    }
}

public class MyData
{
    public string Category { get; set; }
    public int NetProfit { get; set; }
}
