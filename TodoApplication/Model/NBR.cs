namespace TodoApplication.Model
{
    public class Status
    {
        public int code { get; set; }

    }
    public class Errors
    {
        public IList<undefined> validation { get; set; }

    }
    public class Params
    {
        public IList<undefined> date { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public IList<undefined> post_type { get; set; }
        public string per_page { get; set; }
        public string page { get; set; }
        public IList<undefined> slug { get; set; }
        public IList<undefined> q { get; set; }

    }
    public class Currency
    {
        public string iso3 { get; set; }
        public string name { get; set; }
        public int unit { get; set; }

    }
    public class Rates
    {
        public Currency currency { get; set; }
        public string buy { get; set; }
        public string sell { get; set; }

    }
    public class Payload
    {
        public string date { get; set; }
        public DateTime published_on { get; set; }
        public DateTime modified_on { get; set; }
        public IList<Rates> rates { get; set; }

    }
    public class Data
    {
        public IList<Payload> payload { get; set; }

    }
    public class Links
    {
        public IList<undefined> prev { get; set; }
        public IList<undefined> next { get; set; }

    }
    public class undefined
    {

    }
    public class Pagination
    {
        public int page { get; set; }
        public int pages { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public Links links { get; set; }

    }
    public class NBR
    {
        public Status status { get; set; }
        public Errors errors { get; set; }
        public Params param { get; set; }
        public Data data { get; set; }
        public Pagination pagination { get; set; }
    }

}
