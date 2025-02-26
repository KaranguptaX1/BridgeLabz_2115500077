using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class Program{
    static void Main(string[] args){
        string jsonInputPath = "input.json";
        string csvInputPath = "input.csv";
        string jsonOutputPath = "output.json";
        string csvOutputPath = "output.csv";
        string jsonData = File.ReadAllText(jsonInputPath);
        var censoredJson = CensorJsonData(jsonData);
        File.WriteAllText(jsonOutputPath, censoredJson);
        Console.WriteLine("Censored JSON saved to output.json");
        var censoredCsv = CensorCsvData(csvInputPath);
        File.WriteAllText(csvOutputPath, censoredCsv);
        Console.WriteLine("Censored CSV saved to output.csv");
    }
    // CensorJsonData Method for Json file
    static string CensorJsonData(string jsonData){
        var matches = JsonConvert.DeserializeObject<List<JObject>>(jsonData);
        foreach (var match in matches){
            match["team1"] = MaskTeamName(match["team1"].ToString());
            match["team2"] = MaskTeamName(match["team2"].ToString());
            match["winner"] = MaskTeamName(match["winner"].ToString());
            match["player_of_match"] = "REDACTED";
            var score = match["score"] as JObject;
            var newScore = new JObject();
            foreach (var property in score.Properties()){
                newScore[MaskTeamName(property.Name)] = property.Value;
            }
            match["score"] = newScore;
        }
        return JsonConvert.SerializeObject(matches, Formatting.Indented);
    }
    // CensorCsvData Method for CSV file
    static string CensorCsvData(string csvPath){
        var lines = File.ReadAllLines(csvPath).ToList();
        var censoredLines = new List<string> { lines[0] };
        for (int i = 1; i < lines.Count; i++){
            var fields = lines[i].Split(',');            
            fields[1] = MaskTeamName(fields[1]);
            fields[2] = MaskTeamName(fields[2]);
            fields[5] = MaskTeamName(fields[5]);
            fields[6] = "REDACTED";
            censoredLines.Add(string.Join(",", fields));
        }
        return string.Join(Environment.NewLine, censoredLines);
    }
    //Method to mask the team name
    static string MaskTeamName(string teamName){
        var parts = teamName.Split(' ');
        if (parts.Length > 1){
            return $"{parts[0]} ***";
        }
        return teamName;
    }
}