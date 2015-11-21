namespace MVCK.Models
{
    public class QueryOptions{

        public QueryOptions(){
            SortField = "Id";
            SortOrder = SortOrder.ASC;

            CurrentPage = 1;
            PageSize = 2;
        }
        public string SortField { get; set; }

        public SortOrder SortOrder { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PageSize { get; set; }

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

