using Newtonsoft.Json;

namespace DesignPatterns.ProtoType
{
    /// <summary>
    /// Significance of Copying 
    //The idea of using copy is to create a new object of the same type without knowing the exact type of the object we are invoking
    //Shallow Copy and Deep copy plays prominent role in copying the objects in Prototype Design Pattern
    //Creating the required object once and by creating the subsequent required objects by cloning helps reducing the time for creating the objects
    //    With Prototype design pattern, based on the requirement situations we can save memory by cloning the objects
    //Example : Adapting to clone an object which consists of many strings(immutable) is a good idea than creating an object

    //MemberwiseClone Method
    //The MemberwiseClone method is part of system.object and creates a shallow copy of the given object
    //MemberwiseClone Method copies the nonstatic fields of the chosen object to the new object
    //In the process of copying, if a field is a value type, a bit by bit copy of the field is performed.If a field is reference type, the reference is copied but the referenced object is not
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CloneablePrototype<T>
    {
        // Shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep Copy
        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
