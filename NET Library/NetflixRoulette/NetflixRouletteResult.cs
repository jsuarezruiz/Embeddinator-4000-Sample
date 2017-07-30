using System.Runtime.Serialization;

namespace NetflixRoulette
{
    [DataContract]
    public class NetflixRouletteResult
    {
        [DataMember(Name = "unit")]
        public int Unit { get; set; }

        [DataMember(Name = "show_id")]
        public int ShowId { get; set; }

        [DataMember(Name = "show_title")]
        public string ShowTitle { get; set; }

        [DataMember(Name = "release_year")]
        public string ReleaseYear { get; set; }

        [DataMember(Name = "rating")]
        public string Rating { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "show_cast")]
        public string ShowCast { get; set; }

        [DataMember(Name = "director")]
        public string Director { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "poster")]
        public string Poster { get; set; }

        [DataMember(Name = "mediatype")]
        public int MediaType { get; set; }
    }
}