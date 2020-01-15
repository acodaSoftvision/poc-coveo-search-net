namespace poc_coveo_search.Models
{
    public class CustomQueryModel
    {
        public string Q { get; set; }

        public string AQ { get; set; }

        public GroupByModel GroupBy { get; set; } 
    }
}
