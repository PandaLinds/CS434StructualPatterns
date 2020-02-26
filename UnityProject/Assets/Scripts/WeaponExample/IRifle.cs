public interface IRifle
{
    float GetAccuracy();
}

public class BasicRifle : IRifle
{
    private float mBasicRifle = 5.0f;

    public float GetAccuracy()
    {
        return mBasicRifle;
    }
}

