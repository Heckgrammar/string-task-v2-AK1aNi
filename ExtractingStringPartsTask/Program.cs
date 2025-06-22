namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            // output the length of state
            Console.WriteLine(state.Length);
            // Concatenate the contents of city and landmark * don't forget to add a space
            Console.WriteLine(city+", "+landmark);            
            // output the first character of county
            Console.WriteLine(country[0]);
            // output a concatenation of the first and last characters of city
            Console.WriteLine(city.Substring(0,1) + city.Substring(city.Length-1,1));
            // output the substring of landmark starting at c and outputting to the end
            int i = 0 ;
            for(i=0; i<landmark.Length; i++)
            {
                if(landmark[i]=='c')
                {
                    break;
                }
            }
            Console.WriteLine(landmark.Substring(i));
            // output the substring of country starting at the first S and ending at the first A
            int S = 0 ;
            int A = 0 ;
            for(int i=0; i<country.Length;i++)
            {
                if(country[i]=='S')
                {
                    S = i ;
                }
                if(country[i]=='A')
                {
                    A = i+1 ;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(country.Substring(S,A-S));
            // output the position of f in California
            int i = 0 ;
            for(i=0; i<state.Length;i++)
            {
                if(state[i]=='f')
                {
                    break;
                }
            }
            Console.WriteLine(i);
            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels


            

            // Show your evidence of the program running in the Readme file
        }
    }
}
