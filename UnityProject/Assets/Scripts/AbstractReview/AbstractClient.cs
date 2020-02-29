using UnityEngine;

public class AbstractClient : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnPeople();
        }
    }
}