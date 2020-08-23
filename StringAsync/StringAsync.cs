namespace StringAsync
{
    public static class StringAsync
    {
        public static Fake GetAwaiter(this string input) => new Fake(input);
    }
}
