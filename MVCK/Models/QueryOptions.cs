namespace MVCK.Models
{
    public class QueryOptions{

        public QueryOptions(){
            SortField = "Id";
            SortOrder = SortOrder.ASC;
        }
        public string SortField { get; set; }

        public SortOrder SortOrder { get; set; }

        public string Sort {
            get {
                return string.Format("{0} {1}",
                SortField, SortOrder.ToString());
            }
        }
    }

    public enum SortOrder {
        ASC,
        DESC
    }
}

