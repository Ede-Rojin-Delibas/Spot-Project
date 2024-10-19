using System.Text.Json.Serialization;
using Application.ViewModals;
using Domain.Entities;
using Newtonsoft.Json;
using Persistence.Context;

var jsonData = File.ReadAllText("spot.json");
var transferedData = JsonConvert.DeserializeObject<List<Spot>>(jsonData);
foreach (var item in transferedData)
{
    var context = new AppDbContext();
    {
        context.Spot.Add(item);
        context.SaveChanges();
    }
}

var jsonData2 = File.ReadAllText("akisveri.json");
var transferData2 = JsonConvert.DeserializeObject<List<Flow>>(jsonData2);
foreach (var i in transferData2)
{
    var c = new AppDbContext();
    c.Flow.Add(i);
    c.SaveChanges();

}