using CsvHelper.Configuration;
using Data.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopi.map
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Map(m => m.IntegrationId).Name("integration_id"); // csv file does not include this information
            Map(m => m.BaseProductCode).Name("base_product_code");
            Map(m => m.ColorVariantCode).Name("color_variant_code");
            Map(m => m.Sku).Name("sku");
            Map(m => m.StockAmount).Name("stock_amount");
            Map(m => m.Ean).Name("ean");
            Map(m => m.TaxRate).Name("taxrate");
            Map(m => m.Size).Name("size");
            Map(m => m.Title).Name("title");
            Map(m => m.Headline).Name("hedline");  // csv file does not include this information
            Map(m => m.Description).Name("product_description");
            Map(m => m.MainCategory).Name("main_category");
            Map(m => m.FirstSellingVat).Name("first_selling_vat");
            Map(m => m.LastSellingVat).Name("lastsellingvat");
            Map(m => m.Color).Name("color");
            Map(m => m.Image1Link).Name("image1_link");
            Map(m => m.Image2Link).Name("image2_link");
            Map(m => m.Image3Link).Name("image3_link");
            Map(m => m.Image4Link).Name("image4_link");
            Map(m => m.Image5Link).Name("image5_link");
            Map(m => m.WebCategory).Name("web_category");
            Map(m => m.Store).Name("store");    // csv file does not include this information
            Map(m => m.IsDeleted).Name("is_deleted");   // csv file does not include this information
            Map(m => m.IsUnpublished).Name(""); // csv file does not include this information
            Map(m => m.Variant3).Name("variant3");  // csv file does not include this information
            Map(m => m.Variant4).Name("variant4");  // csv file does not include this information
            Map(m => m.Filter3).Name("filter3");   // csv file does not include this information
            Map(m => m.Filter4).Name("filter4");   // csv file does not include this information
            Map(m => m.Filter5).Name("filter5");   // csv file does not include this information
            Map(m => m.Filter6).Name("filter6");   // csv file does not include this information
        }
    }
}
