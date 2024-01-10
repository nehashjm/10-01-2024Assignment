// See https://aka.ms/new-console-template for more information
using Day4EmployeeJenkinsAssignment;

List<Product> products = new List<Product>()
{
    new Product(){PName="Bat",PPrice=20000,PBrand="MRF",ManufacturingDate=new DateTime(day:10,month:10,year:2022),ExpiryDate=new DateTime(day:10,month:10,year:2022)},
    new Product(){PName="Ball",PPrice=25000,PBrand="MRF",ManufacturingDate=new DateTime(day:10,month:10,year:2022),ExpiryDate=new DateTime(day:10,month:10,year:2022)},
    new Product(){PName="Stump",PPrice=28000,PBrand="MRF",ManufacturingDate=new DateTime(day:10,month:10,year:2022),ExpiryDate=new DateTime(day:10,month:10,year:2022)},
    new Product(){PName="Glows",PPrice=29000,PBrand="MRF",ManufacturingDate=new DateTime(day:10,month:10,year:2022),ExpiryDate=new DateTime(day:10,month:10,year:2022)},
    new Product(){PName="Halmet",PPrice=23000,PBrand="MRF",ManufacturingDate=new DateTime(day:10,month:10,year:2022),ExpiryDate=new DateTime(day:10,month:10,year:2022)},

};
Console.WriteLine("Name \t Price \t Brand \t ManuFacturingDate \t ExpiryDate ");
foreach (Product product in products)
{
    Console.Write(product.PName+"\t");
    Console.Write(product.PPrice + "\t");
    Console.Write(product.PBrand+ "\t");
    Console.Write(product.ManufacturingDate + "\t");
    Console.Write(product.ExpiryDate + "\t");
    Console.Write("\n");

}