using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Repository.Content
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();
        public int EpisodeCount
        {
            get { return Episodes.Count; }
        }
        public double AverageRunTIme { get; set; }
        
    }

    public class Episode
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value[0].ToString().ToLower() == value[0].ToString())
                {
                    string capitalizedTitle = "";
                    capitalizedTitle += value[0].ToString().ToUpper();
                    capitalizedTitle += value.ToString().Substring(1);
                    _title = capitalizedTitle;
                }
                else
                {
                    _title = value;
                }
            }
        }
        
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public Episode() { }
        public Episode(string title, double runTime, int seasonNumber )
        {
            Title = title;
            RunTime = runTime;
            SeasonNumber = seasonNumber;
        }
    }
}
