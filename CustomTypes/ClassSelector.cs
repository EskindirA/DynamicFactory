using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTypes
{
    public class DynamicFactory<T> {
        public static T Create(string className)
        {
            Type t = typeof(T);
            return (T)Activator.CreateInstance(
                        t.Assembly.FullName,
                        t.Namespace + "." + className
                      ).Unwrap();
        }
    }

    public class ClassSelector : DynamicFactory<SomeType>
    {
        
    }
}
