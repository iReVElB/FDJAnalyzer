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
    internal class EuroMillions
    {
        public static string[] dateTypes = { "Toutes", "Le", "Entre", "Après", "Avant" };
        private static string base_link_api = "http://127.0.0.1:4000/api/euro_millions/draws";

        public async Task<Result> getResults(Parameters? parameters = null)
        {
            Result result = new Result();
            string link = base_link_api;

            NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(string.Empty);
            if(parameters != null)
            {
                nameValueCollection.Add("Id", parameters.Id.ToString());
                nameValueCollection.Add("DateType", ((int?)parameters.DateType).ToString());
                if(parameters.Date != null)
                {
                    nameValueCollection.Add("Date", parameters.Date.Value.ToString("yyyy-MM-dd"));
                }
                if(parameters.ToDate != null) {
                    nameValueCollection.Add("ToDate", parameters.ToDate.Value.ToString("yyyy-MM-dd"));
                }
                nameValueCollection.Add("HasWinner", parameters.HasWinner.ToString());
            }

            link += $"?{nameValueCollection.ToString()}";
            Debug.WriteLine(link);

            HttpClient httpClient = new HttpClient();
            Stream stream = await httpClient.GetStreamAsync(link);
            List<Draw>? draws = await JsonSerializer.DeserializeAsync<List<Draw>>(stream);

            if(draws != null)
            {
                for(int i = 0; i < draws.Count; i++)
                {
                    Draw draw = draws[i];
                    if(draw.balls != null)
                    {
                        for (int b = 0; b < draw.balls.Length; b++)
                        {
                            if (!result.ballsStats.count.ContainsKey(draw.balls[b]))
                            {
                                result.ballsStats.count.Add(draw.balls[b], 1);
                            } else
                            {
                                result.ballsStats.count[draw.balls[b]]++;
                            }
                            result.ballsStats.total++;
                        }
                    }
                    if (draw.stars != null)
                    {
                        for (int b = 0; b < draw.stars.Length; b++)
                        {
                            if (!result.starsStats.count.ContainsKey(draw.stars[b]))
                            {
                                result.starsStats.count.Add(draw.stars[b], 1);
                            }
                            else
                            {
                                result.starsStats.count[draw.stars[b]]++;
                            }
                            result.starsStats.total++;
                        }
                    }
                }
                foreach (KeyValuePair<int, int> count in result.ballsStats.count)
                {
                    float per = (float)count.Value / result.ballsStats.total;
                    result.ballsStats.per.Add(count.Key, per);
                }
                List<KeyValuePair<int, float>> ballsPerList = result.ballsStats.per.ToList();
                ballsPerList.Sort(delegate (KeyValuePair<int, float> x, KeyValuePair<int, float> y)
                {
                    return x.Value.CompareTo(y.Value);
                });
                for(int i = 0; i < 5; i++)
                {
                    result.ballsStats.min.Add(ballsPerList[i].Value);
                }
                ballsPerList.Reverse();
                for (int i = 0; i < 5; i++)
                {
                    result.ballsStats.max.Add(ballsPerList[i].Value);
                }

                foreach (KeyValuePair<int, int> count in result.starsStats.count)
                {
                    result.starsStats.per.Add(count.Key, (float)count.Value / result.starsStats.total);
                }
                List<KeyValuePair<int, float>> starsPerList = result.starsStats.per.ToList();
                starsPerList.Sort(delegate (KeyValuePair<int, float> x, KeyValuePair<int, float> y)
                {
                    return x.Value.CompareTo(y.Value);
                });
                for (int i = 0; i < 2; i++)
                {
                    result.starsStats.min.Add(starsPerList[i].Value);
                }
                starsPerList.Reverse();
                for (int i = 0; i < 2; i++)
                {
                    result.starsStats.max.Add(starsPerList[i].Value);
                }
            }

            result.draws = draws;
            return result;
        }

        public enum DateType
        {
            All,
            The,
            Between,
            After,
            Before
        }

        public class Parameters
        {
            public int? Id { get; set; }
            public DateType? DateType { get; set; }
            public DateOnly? Date { get; set; }
            public DateOnly? ToDate { get; set; }
            public int? HasWinner { get; set; }
        }
        public class Draw
        {
            public int? id { get; set; }
            public string? date { get; set; }
            public bool? hasWinner { get; set; }
            public int[]? balls { get; set; }
            public int[]? stars { get; set; }
        }
        public class Result
        {
            public List<Draw>? draws { get; set; }
            public BallsStats ballsStats = new BallsStats();
            public BallsStats starsStats = new BallsStats();
            public class BallsStats
            {
                public IDictionary<int, int> count = new Dictionary<int, int>();
                public IDictionary<int, float> per = new Dictionary<int, float>();
                public List<float> min = new List<float>();
                public List<float> max = new List<float>();
                public int total = 0;
            }
            public class StarsStats
            {
                public IDictionary<int, int> count = new Dictionary<int, int>();
                public IDictionary<int, float> per = new Dictionary<int, float>();
                public List<float> min = new List<float>();
                public List<float> max = new List<float>();
                public int total = 0;
            }

        }
    }


}
