using System;
class Product
{
    public static int Length { get; internal set; }
    public string marka { get; set; }
    public int fiyat { get; set; }
    public string beden { get; set; }
    public string renk { get; set; }
}

class MainClass
{
    public static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.marka = "trendyolMilla";
        product1.fiyat = 60;
        product1.beden = "small";
        product1.renk = "mürdüm";

        Product product2 = new Product();
        product2.marka = "kenzo";
        product2.fiyat = 3150;
        product2.beden = "large";
        product2.renk = "ekru";

        Product product3 = new Product();
        product3.marka = "collage";
        product3.fiyat = 80;
        product3.beden = "small";
        product3.renk = "füme";




        Product[] urunler = new Product[]
        {
      product1, product2, product3
        };

        foreach (Product product in urunler)
        {
            Console.WriteLine("Ürün markası:" +product.marka
                + "\n" + "Ürün fiyatı:"
                + product.fiyat
                + "\n" + "Ürün bedeni:"
                + product.beden
                + "\n" + "Ürün rengi:"
                + product.renk);
        }

        Console.WriteLine("\n");


        for (int i = 0;  i < urunler.Length; i++)
        {
            Console.WriteLine("Ürün markası:" + urunler[i].marka + "\n" + "Ürün fiyatı:" + urunler[i].fiyat + "\n" + "Ürün bedeni:" 
                + urunler[i].beden + "\n" + "Ürün rengi:" + urunler[i].renk + "\n");
        }

        int z = 0;
        while (z < urunler.Length)
        {

            Console.WriteLine(" Ürün markası: " + urunler[z].marka + "\n" +
            " Ürün Fiyatı:" + urunler[z].fiyat + "\n" +
            " Ürün bedeni:" + urunler[z].beden + "\n" +
            " Ürün rengi : " + urunler[z].renk);
            z++;
        }





    }
}

