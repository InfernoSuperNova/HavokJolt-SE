namespace Havok {
    public partial class HkTaskProfiler {
        public static void ReplayTimers(BlockBeginFunc blockBegin, BlockEndFunc blockEnd) => throw new NotImplementedException();
        
        
        public delegate void BlockBeginFunc(string name);

        public delegate void BlockEndFunc(long ticks);
    }
}
