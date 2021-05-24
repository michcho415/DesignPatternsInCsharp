using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsInCsharp.Prototype
{
    // prototype is a design pattern that simplyfies creating new objects when we have prototype object

    //base class for all prototypes
    public abstract class CarPrototype : ICloneable
    {
        protected string name { get; }
        protected int horsePower { get; }

        // constructors
        public CarPrototype(string _name, int _horsePower)
        {
            name = _name;
            horsePower = _horsePower;
        }

        //methods
        public abstract object Clone();
        public abstract void PrintMe();
    }

    
    public class FirstCarProto : CarPrototype
    {
        private List<string> properties;

        //constructors
        public FirstCarProto(string name, int horsePower) : base(name, horsePower)
        {
            properties = new List<string>();
        }

        //methods
        public override object Clone()
        {
            //deep copy of current object
            FirstCarProto newObj = new FirstCarProto(name, horsePower);
            foreach(var i in properties)
            {
                newObj.properties.Add(String.Copy(i));
            }

            //return new object
            return newObj;
        }

        public override void PrintMe()
        {
            Console.WriteLine();
        }

        public void addProperty(string prop)
        {
            properties.Add(prop);
        }

        public void removeProperty(int index)
        {
            properties.RemoveAt(index);
        }

        public string this[int index] // operator[]
        {
            get
            {
                if (index > properties.Count)
                    throw new IndexOutOfRangeException();
                else
                    return properties[index];
            }

            set
            {
                if (index > properties.Count)
                {
                    properties.Add(value);
                }
                else
                    properties[index] = value;
            }
            
        }
    }

    public class SecondCarProto : CarPrototype
    {
        private int value { get; set; }

        //constructors
        public SecondCarProto(string _name, int _horsePower) : base(_name, _horsePower)
        {
            
        }

        //methods
        public override object Clone()
        {
            //deep copy
            SecondCarProto newObj = new SecondCarProto(name, horsePower);
            newObj.value = value;

            
            return newObj;
        }

        public override void PrintMe()
        {
            throw new NotImplementedException();
        }
    }

}
