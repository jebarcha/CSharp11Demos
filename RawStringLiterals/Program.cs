using System.Text;

var sb = new StringBuilder();

//var xmlPrologue = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
//var xmlPrologue = @"<?xml version=""1.0"" encoding=""UTF-8""?>";
var xmlPrologue = """<?xml version="1.0" encoding="UTF-8"?>""";
sb.Append(xmlPrologue);
Console.WriteLine(sb.ToString());

//var jsonText = "{\n \"name\": \"Paul McCartney\"\n}";
var name = "Paul McCartney";
var jsonText = $$"""
            {
                "name" : "{{name}}"
            }
            """;
Console.WriteLine(jsonText);