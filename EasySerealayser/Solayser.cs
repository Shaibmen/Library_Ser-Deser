using Newtonsoft.Json;

namespace EasySerealayser
{
    public class Solayser
    {
        static string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\NewJsonFile.json";
        static public void Serialize<T>(T tests)
        {
            string Tojson = JsonConvert.SerializeObject(tests);
            File.WriteAllText(pathToDesktop, Tojson);
        }

        static public T Deserialize<T>()
        {
            string Tojson = File.ReadAllText(pathToDesktop);
            return JsonConvert.DeserializeObject<T>(Tojson);
        }
    }
}
