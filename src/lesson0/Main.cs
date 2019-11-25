using System;

namespace Concept.Generics.Lesson0 {
    class Main {
        public void Run() {
            var i = new MyValue<int>(3);
            var s = new MyValue<string>("abc");
            Console.WriteLine($"{i.Value}, {s.Value}");
        }
    }
    class MyValue<T> {
        public T Value { get; }
        public MyValue(T value) => Value = value;
    }
}
