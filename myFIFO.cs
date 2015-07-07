using GUIdefs;
using HWdefs;

namespace miniFIFO
{
    public class myFIFO
    {
        private FIFOexample[] atErrors = new FIFOexample[(int)eListLenght.MAX_LIST_LNG];
        private uint nIn, nOut;
        private const uint MAXLIST_M1 = ((uint)eListLenght.MAX_LIST_LNG) - 1;
        public myFIFO() { nIn = nOut = 0; }
        public bool isEmpty() { return nIn == nOut ? true : false; }
        public bool isFilled() { return nIn == nOut ? false : true; }
        public bool isFree() { return ((nIn + 1) & MAXLIST_M1) == (nOut & MAXLIST_M1) ? false : true; }
        public void inErr(FIFOexample tErrIn) { atErrors[nIn++ & MAXLIST_M1] = tErrIn; }
        public uint count() { return (nIn - nOut + (uint)eListLenght.MAX_LIST_LNG) & MAXLIST_M1; }
        public FIFOexample outErr() { return atErrors[nOut++ & MAXLIST_M1]; }
        public void clear() { nIn = 0; nOut = 0; }
    }
}
