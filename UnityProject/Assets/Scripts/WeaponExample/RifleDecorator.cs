abstract public class RifleDecorator : IRifle
{
    protected IRifle mDecoratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        mDecoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return mDecoratedRifle.GetAccuracy();
    }
}
