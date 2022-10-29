



using NistApi.Request;
using NistApi.Request.Models;
using System.Text.Json;

var dataList = TakeList();

var dataString = JsonSerializer.Serialize(dataList);
var toWriteData = "[" + dataString + "]";
Console.WriteLine("Dosya yazılavak!!!!!!!!!!");

File.WriteAllText("./data.json", toWriteData);

Console.WriteLine("Dosya yazıldı!!!!!!!!");




static async Task<List<Root>> TakeList()
{
    var URL = "https://services.nvd.nist.gov/rest/json/cves/2.0/?resultsPerPage=2000&startIndex=0";

    var index = 0;

    var _nistApiService = new NistApiService();

    var list = new List<Root>();
    for(var i =0; i <= 26; i++)
    {
        var model = await _nistApiService.Get(URL);
        list.Add(model);
        Console.WriteLine(model.vulnerabilities[0].cve.descriptions[0].value);

        index += 2000;

        var stringArray = URL.Split("=");

        stringArray[2] = index.ToString();

        URL = stringArray[0] + "=" + stringArray[1] + "=" + stringArray[2];
    }

    Console.WriteLine("Data başarılı bi şekilde çekildi.....");
    return list;

}
