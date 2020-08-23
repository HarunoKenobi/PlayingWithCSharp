using System;
using System.Runtime.CompilerServices;

namespace StringAsync
{
    public class Fake : INotifyCompletion
    {
        private readonly string Input;

        public Fake(string input)
        {
            this.Input = input;
        }

        public bool IsCompleted { get; set; }

        public string GetResult() => Input;

        public void OnCompleted(Action continuation) => continuation?.Invoke();
    }
}
