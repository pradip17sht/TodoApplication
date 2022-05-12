namespace TodoApplication.Model
{

    public class NBR
    {
        public string _namespace { get; set; }
        public Routes routes { get; set; }
        public _Links4 _links { get; set; }
    }

    public class Routes
    {
        public ForexV1 forexv1 { get; set; }
        public ForexV1Rates forexv1rates { get; set; }
        public ForexV1Rate forexv1rate { get; set; }
        public ForexV1AppRate forexv1apprate { get; set; }
    }

    public class ForexV1
    {
        public string _namespace { get; set; }
        public string[] methods { get; set; }
        public Endpoint[] endpoints { get; set; }
        public _Links _links { get; set; }
    }

    public class _Links
    {
        public string self { get; set; }
    }

    public class Endpoint
    {
        public string[] methods { get; set; }
        public Args args { get; set; }
    }

    public class Args
    {
        public Namespace _namespace { get; set; }
        public Context context { get; set; }
    }

    public class Namespace
    {
        public bool required { get; set; }
        public string _default { get; set; }
    }

    public class Context
    {
        public bool required { get; set; }
        public string _default { get; set; }
    }

    public class ForexV1Rates
    {
        public string _namespace { get; set; }
        public string[] methods { get; set; }
        public Endpoint1[] endpoints { get; set; }
        public _Links1 _links { get; set; }
    }

    public class _Links1
    {
        public string self { get; set; }
    }

    public class Endpoint1
    {
        public string[] methods { get; set; }
        public object[] args { get; set; }
    }

    public class ForexV1Rate
    {
        public string _namespace { get; set; }
        public string[] methods { get; set; }
        public Endpoint2[] endpoints { get; set; }
        public _Links2 _links { get; set; }
    }

    public class _Links2
    {
        public string self { get; set; }
    }

    public class Endpoint2
    {
        public string[] methods { get; set; }
        public object[] args { get; set; }
    }

    public class ForexV1AppRate
    {
        public string _namespace { get; set; }
        public string[] methods { get; set; }
        public Endpoint3[] endpoints { get; set; }
        public _Links3 _links { get; set; }
    }

    public class _Links3
    {
        public string self { get; set; }
    }

    public class Endpoint3
    {
        public string[] methods { get; set; }
        public object[] args { get; set; }
    }

    public class _Links4
    {
        public Up[] up { get; set; }
    }

    public class Up
    {
        public string href { get; set; }
    }

}
