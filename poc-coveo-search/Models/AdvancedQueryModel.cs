﻿namespace poc_coveo_search.Models
{
    public class AdvancedQueryModel
    {
        /// <summary>
        /// The basic query expression, typically the keywords entered by the end user in a query box.
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// The advanced query expression, typically generated by code (e.g., when toggling facet values).
        /// </summary>
        public string AQ { get; set; }
    }
}
