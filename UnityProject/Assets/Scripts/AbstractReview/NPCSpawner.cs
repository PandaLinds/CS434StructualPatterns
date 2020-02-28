using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory mFactory;

    private INPC mFarmer;
    private INPC mBeggar;
    private INPC mShopowner;

    public void SpawnVillagers()
    {
        mFarmer = mFactory.GetNPC(NPCType.Farmer);
        mBeggar = mFactory.GetNPC(NPCType.Beggar);
        mShopowner = mFactory.GetNPC(NPCType.Shopowner);

        mFarmer.Speak();
        mBeggar.Speak();
        mShopowner.Speak();
    }
}
