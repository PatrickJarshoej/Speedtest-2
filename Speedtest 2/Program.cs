namespace Speedtest_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> Ingredients = new();

            Ingredients.Add("200g hvedemel, (ca 3 1/2 dl)");
            Ingredients.Add("2 teskefulde bagepulver");
            Ingredients.Add("1/2 teskefuld fint salt");
            Ingredients.Add("2 æg");
            Ingredients.Add("150 g sukker (ca 1 3/4 dl)");
            Ingredients.Add("1 teskefuld vaniljesukker");
            Ingredients.Add("125 g smeltet smør");
            Ingredients.Add("2 modene bananer");
            Ingredients.Add("100 g mørk chokolade");

            foreach (string ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }

        }
    }
}
