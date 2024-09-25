using System;

public class Rate
{
    public string currency { get; set; }
    public string code { get; set; }
    public double mid { get; set; }
}

public class RatesTable
{
    public string table { get; set; }
    public string no { get; set; }
    public string effectiveDate { get; set; }
    public List<Rate> rates { get; set; }
}