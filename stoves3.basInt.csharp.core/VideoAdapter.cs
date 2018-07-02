namespace stoves3.basInt.csharp.core
{
    public enum Adapter
    {
        MDPA,
        CGA,
        Hercules,
        Olivetti,
        EGA64K,
        EGA,
        VGA,
        MCGA
    }

    public enum AdapterMemory
    {
        mUnder64K = 0,
        m64K = 64,
        m128K = 128,
        m256K = 256
    }

    public enum PageSize
    {
        m2K = 2,
        m4K = 4,
        m16K = 16,
        m32K = 32,
        m64K = 64,
        m128K = 128
    }
}
