using CsvHelper;
using CsvHelper.Configuration;
using Data.Model.Request;
using Newtonsoft.Json;
using Shopi.map;
using Shopi.service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Shopi
{
    class ParseCsvFile
    {
        ImportProductsRequest productsRequest;

        string file = @"C:\Users\oguzhans\source\repos\Shopi\sample\sample.csv";

        public ParseCsvFile()
        {
            productsRequest = new ImportProductsRequest();
            
            Parse();
        }

        public void Parse()
        {
            using (var reader = new StreamReader(file))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) 
                {
                    Delimiter = "|", 
                    HeaderValidated = null, // For the ignore missing headers
                    MissingFieldFound = null // For the ignore missing values
                };

                using (var csv = new CsvReader(reader, config))
                {
                    try
                    {
                        csv.Context.RegisterClassMap<ProductMap>();
                        productsRequest.ProductList = csv.GetRecords<Product>().ToList();
                        ConvertToJsonCallAPI(productsRequest.ProductList);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        private void ConvertToJsonCallAPI(List<Product> products)
        {
            var jsonData = JsonConvert.SerializeObject(products);
            new APIService(jsonData);
        }
    }
}
