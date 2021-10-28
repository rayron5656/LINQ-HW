using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinQ0
{
    partial class Program
    {
        static List<State> states = new List<State>();

        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 10, 5, 87, 9, 29, 3000, 12, -15 };
            string[] names = new string[] { "Ron", "Dor", "Regev", "Or", "Jonathan" };


            

            states.Add(new State("AL", "Alabama", 1));
            states.Add(new State("AK", "Alaska", 2));
            states.Add(new State("AZ", "Arizona", 2));
            states.Add(new State("AR", "Xrkansas", 2));
            states.Add(new State("CA", "California", 3));
            states.Add(new State("CO", "Colorado", 2));
            states.Add(new State("CT", "Xonnecticut", 2));
            states.Add(new State("DE", "Delaware", 12312));
            states.Add(new State("DC", "District Of Columbia", 2));
            states.Add(new State("FL", "Florida", 75543));
            states.Add(new State("GA", "Georgia", 76568769));
            states.Add(new State("HI", "Hawaii", 45857957));
            states.Add(new State("ID", "Idaho", 4564537));
            states.Add(new State("IL", "Illinois", 12346));
            states.Add(new State("IN", "Indiana", 867960));
            states.Add(new State("IA", "Iowa", 565896));
            states.Add(new State("KS", "Kansas", 2));
            states.Add(new State("KY", "Kentucky", 2));
            states.Add(new State("LA", "Louisiana", 2));
            states.Add(new State("ME", "Maine", 2));
            states.Add(new State("MD", "Maryland", 2));
            states.Add(new State("MA", "Massachusetts", 2));
            states.Add(new State("MI", "Michigan", 2));
            states.Add(new State("MN", "Minnesota", 2));
            states.Add(new State("MS", "Mississippi", 2));
            states.Add(new State("MO", "Missouri", 2));
            states.Add(new State("MT", "Montana", 2));
            states.Add(new State("NE", "Nebraska", 2));
            states.Add(new State("NV", "Nevada", 2));
            states.Add(new State("NH", "New Hampshire", 2));
            states.Add(new State("NJ", "New Jersey", 2));
            states.Add(new State("NM", "New Mexico", 2));
            states.Add(new State("NY", "New York", 2));
            states.Add(new State("NC", "North Carolina", 2));
            states.Add(new State("ND", "North Dakota", 2));
            states.Add(new State("OH", "Ohio", 2));
            states.Add(new State("OK", "Oklahoma", 2));
            states.Add(new State("OR", "Oregon", 2));
            states.Add(new State("PA", "Pennsylvania", 2));
            states.Add(new State("RI", "Rhode Island", 2));
            states.Add(new State("SC", "South Carolina", 2));
            states.Add(new State("SD", "South Dakota", 2));
            states.Add(new State("TN", "Tennessee", 2));
            states.Add(new State("TX", "Texas", 2));
            states.Add(new State("UT", "Utah", 2));
            states.Add(new State("VT", "Vermont", 2));
            states.Add(new State("VA", "Virginia", 2));
            states.Add(new State("WA", "Washington", 2));
            states.Add(new State("WV", "West Virginia", 2));
            states.Add(new State("WI", "Wisconsin", 2));
            states.Add(new State("WY", "Wyoming", 2));


            //Fetch all negetive numbers QST1
            var query = from Number in Numbers
                        where Number <= 0
                        select Number;

            var Query = Numbers.Where(number => number <= 0);



            //Fetch all odd numbers QST2
            var myquery = from number in Numbers
                          where number % 2 == 1
                          orderby number
                          descending
                          select number;

            var MyQuery = Numbers.OrderByDescending(number => number % 2 == 1);



            //QST3 
            var myquery2 = from number in Numbers
                           where number > 5 && number % 3 != 0
                           select number * 3;

            var MyQuery2 = Numbers.Where(number => number > 5 && number % 3 != 0);

            //QST4
            string s = Console.ReadLine();

            


            var Q4 = getByS(s);

            var QQ4 = GetByS(s);


            //QST5
            string ss = Console.ReadLine();

            var Q5 = DontgetByS(ss);

            var QQ5 = DontGetByS(ss);


            //QST6

            var Q6 = (from state in states
                      where state.Name[0] == 'X'
                      select state).First();


            var QQ6 = states.First(state => state.Name[0] == 'X');

            //Qst7 

            var Q7 = (from state in states
                      orderby state.Name
                      ascending
                      select state).Take(3);

            var QQ7 = states.OrderBy(state => state.Name).Take(3);

            //QSt8

            var Q8 = from state in states
                     where state.Population > 25000
                     select state;

            var QQ8 = states.Where(state => state.Population > 25000);

            //QST9

            var Q9 = from state in states
                     where state.Population > 25000
                     select state.Name;

            var QQ9 = states.Where(state => state.Population > 25000).Select(state => state.Name);

            //QST10

            var Q10 = from state in states
                      
                      select new CityIdntify(state.Name, state.Population);
                     

           var QQ10 = states.Select(state => new CityIdntify(state.Name, state.Population));

            var Q110 = from state in states //Same but anonymous

                      select new { state.Name, iscity = state.Population > 25000 };


            var QQ110 = states.Select(state => new { state.Name, iscity = state.Population > 25000 });

            var Q1110 = from state in states //Same but anonymous and with enum

                        select new { state.Name, iscity = state.Population > 25000 ? cityortown.city: cityortown.Town };


            var QQ1110 = states.Select(state => new { state.Name, iscity = state.Population > 25000? cityortown.city : cityortown.Town });

        }

        static IEnumerable getByS(string s)
        {
            var q =  (from state in states
                    where state.Name == s
                    select state).ToArray();
            return q;
        }

        static IEnumerable GetByS(string s)
        {
            var q = states.Where(state => state.Name == s).ToArray();
            return q;
        }

        static IEnumerable DontgetByS(string s)
        {
            var q = (from state in states
                         where state.Name != s
                         select state).ToArray();
            return q;
        }

        static IEnumerable DontGetByS(string s)
        {
            var q = states.Where(state => state.Name != s).ToArray();
            return q;
        }



    }
}
