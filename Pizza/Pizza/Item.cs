using System;
namespace Pizza
{
    class Item
    {
        Article article;
        int quantity;

        public Item(Article _article, int _quantity)
        {
            article = _article;
            quantity = _quantity;
        }
        public Article Article
        {
            get { return article; }
        }
        public void PrintItem()
        {
            Console.WriteLine($"ID: {article.Id} \n Name: {article.Name} \n Category: {article.Category} " +
                  $"\n Price: {article.Price} \n Quantity: {quantity} \n Total: {CalculateItemTotal()} ");
        }
        /*public string Article
        {
            get
            {
                return $"ID: {article.Id} \n Name: {article.Name} \n Category: {article.Category} " +
                  $"\n Price: {article.Price} \n Quantity: {quantity} \n Total: {CalculateItemTotal()} ";
            }
        }*/
        public double CalculateItemTotal()
        {
            return article.Price * quantity;
        }
    }
}
