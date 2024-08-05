using System;
namespace ParametersTest
{
    public class Car
    {
        public Car()
        {

        }
        public void MapValue(string TypeValue)
        {
            TypeValue = "Changed Value";
            Console.WriteLine($"2_title: {TypeValue}");
        }

        public void MapRef(ref string TypeReferance)
        {
            TypeReferance = "Changed Referance"; // referance Type 변경 Main의 오리지널 변경됨
            Console.WriteLine($"2_title: {TypeReferance}");
        }

        public void MapOut(out string TypeOutput)
        {
            TypeOutput = "Return Out"; // referance Type 변경 Main의 오리지널 변경됨
            Console.WriteLine($"2_title: {TypeOutput}");
        }

        public void MapParams(params string[] TypeParams)
        {
            foreach (var p in TypeParams)
            {
                Console.WriteLine(p);
            }
        }

        public void MapOptional(string message, string prefix = "", string suffix = "")
        {
            Console.WriteLine($"{prefix}{message}{suffix}");
        }

    }
}
