using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace FDJAnalyzer
{
    internal class EuroMillionsManager
    {
        public static string[] DateTypes = { "Toutes", "Le", "Entre", "Après", "Avant" };
        private static string base_link_api = "http://127.0.0.1:4000/api/euro_millions/draws";

        public async Task<Result> GetResult(Parameters? parameters)
        {
            Result result = new Result();
            List<Draw>? draws = await getDraws(parameters);
            result.draws = draws;
            IDictionary<int, int> balls_count = new Dictionary<int, int>();
            IDictionary<int, int> stars_count = new Dictionary<int, int>();
            if (draws != null)
            {
                for(int i = 0;  i < draws.Count; i++)
                {
                    Draw draw = draws[i];
                    int[]? balls = draw.balls;
                    int[]? stars = draw.stars;
                    if(balls != null)
                    {
                        for(int b = 0; b < balls.Length; b++)
                        {
                            int ball = balls[b];
                            Result.Stats stats = result.ballsStats;
                            if (balls_count.ContainsKey(ball)) { balls_count[ball]++; } else { balls_count.Add(ball, 1); }
                            stats.total++;
                        }
                    }
                    if(stars != null)
                    {
                        for(int s = 0; s < stars.Length; s++)
                        {
                            int star = stars[s];
                            Result.Stats stats = result.starsStats;
                            if (stars_count.ContainsKey(star)) { stars_count[star]++; } else { stars_count.Add(star, 1); }
                            stats.total++;
                        }
                    }
                }
                for(int i = 0; i < balls_count.Count; i++)
                {
                    Result.Stats stats = result.ballsStats;
                    KeyValuePair<int, int> keyValuePair = balls_count.ElementAt(i);
                    float per = (float)keyValuePair.Value / stats.total;
                    KeyValuePair<int, KeyValuePair<int, float>> item = new KeyValuePair<int, KeyValuePair<int, float>>(keyValuePair.Key, new KeyValuePair<int, float>(keyValuePair.Value, per));
                    stats.stats.Add(item);
                }
                for(int i = 0; i < stars_count.Count; i++)
                {
                    Result.Stats stats = result.starsStats;
                    KeyValuePair<int, int> keyValuePair = stars_count.ElementAt(i);
                    float per = (float)keyValuePair.Value / stats.total;
                    KeyValuePair<int, KeyValuePair<int, float>> item = new KeyValuePair<int, KeyValuePair<int, float>>(keyValuePair.Key, new KeyValuePair<int, float>(keyValuePair.Value, per));
                    stats.stats.Add(item);
                }
            }
            return result;
        }

        private async Task<List<Draw>?> getDraws(Parameters? parameters)
        {
            string link = base_link_api;
            NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(string.Empty);
            if (parameters != null)
            {
                nameValueCollection.Add("Id", parameters.Id.ToString());
                nameValueCollection.Add("DateType", ((int?)parameters.DateType).ToString());
                if (parameters.Date != null) { nameValueCollection.Add("Date", parameters.Date.Value.ToString("yyyy-MM-dd")); }
                if (parameters.ToDate != null) { nameValueCollection.Add("ToDate", parameters.ToDate.Value.ToString("yyyy-MM-dd")); }
                nameValueCollection.Add("HasWinner", parameters.HasWinner.ToString());
            }
            link += $"?{nameValueCollection.ToString()}";
            Debug.WriteLine(link);
            HttpClient httpClient = new HttpClient();
            Stream stream = await httpClient.GetStreamAsync(link);
            List<Draw>? draws = await JsonSerializer.DeserializeAsync<List<Draw>>(stream);
            return draws;
        }

        public class Result
        {
            public List<Draw>? draws {  get; set; }
            public Stats ballsStats = new Stats();
            public Stats starsStats = new Stats();
            public class Stats
            {
                public List<KeyValuePair<int, KeyValuePair<int, float>>> stats = new List<KeyValuePair<int, KeyValuePair<int, float>>>();
                public List<float> min = new List<float>();
                public List<float> max = new List<float>();
                public int total = 0;
            }
        }
        public class Parameters
        {
            public int? Id { get; set; }
            public DateType? DateType { get; set; }
            public DateOnly? Date { get; set; }
            public DateOnly? ToDate { get; set; }
            public int? HasWinner { get; set; }
        }
        public enum DateType
        {
            All,
            The,
            Between,
            After,
            Before
        }
        public class Draw
        {
            public int? id { get; set; }
            public string? date { get; set; }
            public bool? hasWinner { get; set; }
            public int[]? balls { get; set; }
            public int[]? stars { get; set; }
        }

    }


}
