using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static partial class ObjectExtentions 
{

    public static T DeepCopy<T>(this T self)
    {
        if (!typeof(T).IsSerializable)
        {
            throw new ArgumentException("Type must be iserializable");
        }
        if (ReferenceEquals(self, null))
        {
            return default;
        }
        var fromatter = new BinaryFormatter();
        using (var stream = new MemoryStream())
        {
            fromatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            return (T)fromatter.Deserialize(stream);
        }
    }
    
}
