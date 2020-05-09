using System;
using System.Collections.Generic;

namespace Library
{
    public class Singleton<T> where T : new()
    {
        private static List<T> alotoff = new List<T>();
        private static T instance;
        public static T Instance
        {
            get
            {
                if ( instance == null)
                {
                    instance = new T();
                    
                }
                alotoff.Add(instance);
                return instance;
            }

        }
        
    }

}