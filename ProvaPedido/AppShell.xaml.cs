namespace ProvaPedido
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void value(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Console.WriteLine("Generating 10 random numbers:");

            for (uint ctr = 1; ctr <= 10; ctr++)
                Console.WriteLine($"{rnd.Next(),15:N0}");
        }

        private void Random(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Console.WriteLine("Generating 10 random numbers:");

            for (uint ctr = 1; ctr <= 10; ctr++)
                Console.WriteLine($"{rnd.Next(),15:N0}");

            var Random = new List<string>();
            Random.Add("4");
            Random.Add("6");
            Random.Add("8");
            Random.Add("10");
            Random.Add("12");
            Random.Add("20");
            Random.Add("100");

            Picker picker = new Picker { Title = "Select a monkey" };
            picker.ItemsSource = Random;

        }


        private void Bt(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Console.WriteLine("Generating 10 random numbers:");

            for (uint ctr = 1; ctr <= 10; ctr++)
                Console.WriteLine($"{rnd.Next(),15:N0}");

        }
    }
}
