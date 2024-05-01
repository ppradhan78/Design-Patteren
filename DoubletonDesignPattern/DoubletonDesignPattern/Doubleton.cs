namespace DoubletonDesignPattern
{
    public class Doubleton
    {
        public static int count = 0;
        private Doubleton()
        {
            count++;
        }
        private static int call = 0;
        private static Doubleton[] instances = {
                      new Doubleton(), new Doubleton() };
        public static Doubleton getInstance()
        {
            return instances[call++ % 2];
        }
    }
}
