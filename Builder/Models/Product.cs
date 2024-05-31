using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Models
{
    public abstract class Product // : IProductBuilder
    {
        private LinkedList<string> _parts;

        public Product()
        {
            _parts = new LinkedList<string>();
        }

        public abstract void setBrandName(string brand);

        public abstract void StartUpOperations();
        public abstract void BuildBody();
        public abstract void InsertWheels();
        public abstract void AddHeadlights();
        public abstract void EndOperations();

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

        public void prepareProduct() 
        {
            StartUpOperations();
            BuildBody();
            InsertWheels();
            AddHeadlights();
            EndOperations();
        }
    }
}