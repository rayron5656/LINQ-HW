namespace LinQ0
{
    partial class Program
    {
        public class State
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public int Population { get; set; }

            public State(string code, string name, int population)
            {
                Code = code;
                Name = name;
                Population = population;
            }

            
        }

        enum cityortown { city, Town }

        class CityIdntify
        {
            public string Name { get; set; }
            public cityortown cityortown;

            public CityIdntify(string name, int I)
            {
                Name = name;
                if (I >= 25000)
                {
                    cityortown = cityortown.city;
                }
                else
                {
                    cityortown = cityortown.Town;
                }
            }
        }
    }
}
