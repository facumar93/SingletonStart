﻿using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton<Greeter>.Instance.SayHiToTheWorld();
            Singleton<Greeter>.Instance.SayHiToTheWorld();
            Singleton<Joke>.Instance.SaySomething();
        }
    }
}
