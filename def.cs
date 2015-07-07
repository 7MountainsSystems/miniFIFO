namespace HWdefs
{
    enum eListLenght
    {
        MAX_LIST_ERRORS = 128,  // must be a power of 2
    }
}

namespace GUIdefs
{
    public struct CNTRERROR
    {
		public int nST;
        public ushort nError;

        public byte nByte1;
        public byte nByte2;
        public byte nByte3;
        public byte nByte4;
        public byte nByte5;
        public byte nByte6;
        public byte nByte7;
        public byte nByte8;
    }
}

