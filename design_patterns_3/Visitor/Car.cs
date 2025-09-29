using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace design_patterns_3.Visitor
{
    public class Car : IAccepter
    {
        public Car(string model, int price)
        {
            Model = model;
            Price = price;
        }

        public string Model { get; set; }
        public int Price { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public object Item => this;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
