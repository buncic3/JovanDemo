namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Auto> dict = new Dictionary<int, Auto>();
            List<Auto> list = new List<Auto>();

            int v = 1000000*4;
            for (int i = 0; i < v; i++)
            {
                var a = new Auto();
                list.Add(a);
                dict[a.Id] = a;
            }

            var auto = list.FirstOrDefault(x => x.Id == v);
            var dictAuto = dict[v];
        }
    }
}