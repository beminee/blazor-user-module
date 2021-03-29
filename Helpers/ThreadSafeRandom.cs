namespace LoginRegister.Helpers
{
    public class ThreadSafeRandom : System.Random
    {
        private object _syncRoot;
        public object SyncRoot
        {
            get
            {
                if (_syncRoot == null)
                    System.Threading.Interlocked.CompareExchange(ref _syncRoot, new object(), null);
                return _syncRoot;
            }
        }
        public override int Next(int minVal, int maxVal)
        {
            lock (SyncRoot)
                return base.Next(minVal, maxVal);
        }
    }
}
