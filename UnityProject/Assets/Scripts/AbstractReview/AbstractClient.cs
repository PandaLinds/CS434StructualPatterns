using UnityEngine;

public class AbstractClient : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_SpawnerNPC.SpawnCowboys();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnCityboys();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_SpawnerNPC.SpawnWeenies();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            m_SpawnerNPC.SpawnHorses();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_SpawnerNPC.SpawnBull();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            m_SpawnerNPC.SpawnDog();
        }
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 500, 20), "Q - Horse and Animal decorators");
        GUI.Label(new Rect(10, 25, 500, 20), "W - Bull and Animal decorators");
        GUI.Label(new Rect(10, 40, 500, 20), "E - Wiener Dog and Animal decorators");
        GUI.Label(new Rect(10, 55, 500, 20), "A - Cowboy and People decorators");
        GUI.Label(new Rect(10, 70, 500, 20), "S - Cityboy and People decorators");
        GUI.Label(new Rect(10, 85, 500, 20), "D - Weenie and People decorators");
        GUI.Label(new Rect(10, 100, 500, 20), "Output is in Debug.Log!");
    }
}