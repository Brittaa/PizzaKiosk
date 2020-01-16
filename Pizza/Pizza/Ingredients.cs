using System;
using System.Collections.Generic;

namespace Pizza
{
    class Ingredients
    {
        List<Article> InStock;

        public Ingredients()
        {
            InStock = new List<Article>();

            Article Americana = new Article(1, "Americana pizza", Category.PIZZA, 8.20);
            InStock.Add(Americana);

            Article Bolognese = new Article(2, "Bolognese pizza", Category.PIZZA, 7.60);
            InStock.Add(Bolognese);

            Article Francescana = new Article(3, "Francescana pizza", Category.PIZZA, 8.60);
            InStock.Add(Francescana);

            Article Hawaii = new Article(4, "Hawaii pizza", Category.PIZZA, 7.80);
            InStock.Add(Hawaii);

            Article Pepperoni = new Article(5, "Pepperoni pizza", Category.PIZZA, 8.40);
            InStock.Add(Pepperoni);

            Article Pannipizza = new Article(6, "Pannipizza", Category.DOUGH, 1.0);
            InStock.Add(Pannipizza);

            Article Õhukepizza = new Article(7, "Õhuke pizza", Category.DOUGH, 0.0);
            InStock.Add(Õhukepizza);

            Article juust = new Article(8, "juust", Category.EXTRA, 0.50);
            InStock.Add(juust);

            Article tomato = new Article(9, "tomato", Category.EXTRA, 0.50);
            InStock.Add(tomato);

            Article olive = new Article(10, "olive", Category.EXTRA, 0.30);
            InStock.Add(olive);

            Article ananass = new Article(11, "ananass", Category.EXTRA, 0.50);
            InStock.Add(ananass);

            Article mozzarella = new Article(12, "mozzarella", Category.EXTRA, 0.50);
            InStock.Add(mozzarella);

            Article paprika = new Article(13, "paprika", Category.EXTRA, 0.50);
            InStock.Add(paprika);

            Article sink = new Article(14, "sink", Category.EXTRA, 0.50);
            InStock.Add(sink);

            Article salami = new Article(15, "salami", Category.EXTRA, 0.50);
            InStock.Add(salami);

            Article jalapeno = new Article(16, "jalapeno", Category.EXTRA, 0.50);
            InStock.Add(jalapeno);
        }
        public void PrintInStock()
        {
            foreach (Article article in InStock)
            {
                Console.WriteLine($"ID: {article.Id}");
                Console.WriteLine($"Product: {article.Name}");
                Console.WriteLine($"Category: {article.Category}");
                Console.WriteLine($"Price: {article.Price}");
                Console.WriteLine("\n");
            }
        }
        // Get an article object from the list
        public Article GetFromStock(int id)
        {
            return InStock[id - 1];
        }
    }
}
