using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Product
    {
        private LinkedList<string> _parts;

        public Product()
        {
            _parts = new LinkedList<string>();
        }

        public void Add(string part)
        {
            // Add car parts
            _parts.AddLast(part);
        }

        public string Show()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Product components are :");
           
            foreach (string part in _parts)
                result.AppendLine(part);

            return result.ToString();
        }

        public override string ToString()
        {
            return Show();
        }
    }
}