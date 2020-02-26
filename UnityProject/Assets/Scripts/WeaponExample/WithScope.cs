public class WithScope : RifleDecorator
{
    private float mScopeAccuracy = 20.0f;

    //constructor
    public WithScope(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + mScopeAccuracy;
    }
}
