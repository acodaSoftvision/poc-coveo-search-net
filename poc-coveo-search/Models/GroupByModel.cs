using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc_coveo_search.Models
{
    public class GroupByModel
    {
        /// <summary>
        /// Field that we want to group by.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Order that we want. The posible values are score, occurrences, alphaascending/alphadescending
        /// computedfieldascending/computedfielddescending, chisquare and nosort.
        /// As default it will order for page score.
        /// </summary>
        public string SortCriteria { get; set; }
    }
}
