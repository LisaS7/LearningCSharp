namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main()
        {
            var method = ShippingMethod.Express;

            // cast to int to get number
            Console.WriteLine((int)method);

            // or cast a number to the enum to get the string representation
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // String representation
            Console.WriteLine(method.ToString());

            // Convert string to enum 
            var methodName = "Express";
            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }


}
