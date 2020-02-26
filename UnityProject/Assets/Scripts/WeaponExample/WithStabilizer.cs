public class WithStabilizer : RifleDecorator
{
    private float mStabilizerAccuracy = 10.0f;

    //constructor
    public WithStabilizer(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + mStabilizerAccuracy;
    }
}
