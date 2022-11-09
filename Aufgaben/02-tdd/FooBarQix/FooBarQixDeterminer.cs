namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            var result = "";
            
            if (input % 3 == 0)
            {
                result += "foo";
            }
            if (input % 5 == 0)
            {
                result += "bar";
            }

            if (input % 7 == 0)
            {
                result += "qix";
            }
            if (result == "")
            {
                result += input.ToString();
            }

            return result;
        }
    }
}