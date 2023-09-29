namespace ConsoleApp1
{

    public class Auto
    {
        public int Id { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        public string Value5 { get; set; }
        public string Value6 { get; set; }
        public string Value7 { get; set; }
        public string Value8 { get; set; }
        public string Value9 { get; set; }
        public string Value10 { get; set; }
        public string Value11 { get; set; }
        public string Value12 { get; set; }
        public string Value13 { get; set; }
        public string Value14 { get; set; }
        public string Value15 { get; set; }
        public string Value16 { get; set; }
        public string Value17 { get; set; }
        public string Value18 { get; set; }
        public string Value19 { get; set; }
        public string Value20 { get; set; }
        public string Value21 { get; set; }
        public string Value22 { get; set; }
        public string Value23 { get; set; }
        public string Value24 { get; set; }
        public string Value25 { get; set; }
        public string Value26 { get; set; }
        public string Value27 { get; set; }
        public string Value28 { get; set; }
        public string Value29 { get; set; }

        public Auto()
        {
            Id = Constants.LastId + 1;
            Constants.LastId++; // lastId = lastId + 1;
            Value1 = Random.Shared.NextInt64().ToString();
            Value2 = Random.Shared.NextInt64().ToString();
            Value3 = Random.Shared.NextInt64().ToString();
            Value4 = Random.Shared.NextInt64().ToString();
            Value5 = Random.Shared.NextInt64().ToString();
            Value6 = Random.Shared.NextInt64().ToString();
            Value7 = Random.Shared.NextInt64().ToString();
            Value8 = Random.Shared.NextInt64().ToString();
            Value9 = Random.Shared.NextInt64().ToString();
            Value10 = Random.Shared.NextInt64().ToString();
            Value11 = Random.Shared.NextInt64().ToString();
            Value12 = Random.Shared.NextInt64().ToString();
            Value13 = Random.Shared.NextInt64().ToString();
            Value14 = Random.Shared.NextInt64().ToString();
            Value15 = Random.Shared.NextInt64().ToString();
            Value16 = Random.Shared.NextInt64().ToString();
            Value17 = Random.Shared.NextInt64().ToString();
            Value18 = Random.Shared.NextInt64().ToString();
            Value19 = Random.Shared.NextInt64().ToString();
            Value20 = Random.Shared.NextInt64().ToString();
            Value21 = Random.Shared.NextInt64().ToString();
            Value22 = Random.Shared.NextInt64().ToString();
            Value23 = Random.Shared.NextInt64().ToString();
            Value24 = Random.Shared.NextInt64().ToString();
            Value25 = Random.Shared.NextInt64().ToString();
            Value26 = Random.Shared.NextInt64().ToString();
            Value27 = Random.Shared.NextInt64().ToString();
            Value28 = Random.Shared.NextInt64().ToString();
            Value29 = Random.Shared.NextInt64().ToString();
        }
    }
}
