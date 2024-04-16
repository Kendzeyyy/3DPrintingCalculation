using System;
using System.Collections.Generic;

public class ApiResponseDTO
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public ElectricityData Today { get; set; }
        public ElectricityData Tomorrow { get; set; }
    }

    public class ElectricityData
    {
        public bool DataOk { get; set; }
        public List<PriceInfo> Prices { get; set; }
        public Options Options { get; set; }
    }

    public class PriceInfo
    {
        public double Price { get; set; }
        public string Date { get; set; }
    }

    public class Options
    {
        public double Average { get; set; }
        public PriceInfo Highest { get; set; }
        public PriceInfo Lowest { get; set; }
    }
}
