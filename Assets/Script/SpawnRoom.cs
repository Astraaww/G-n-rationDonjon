using Unity.VisualScripting;
using UnityEngine;

public class SpawnRoom : MonoBehaviour
{
    // Direction
    [SerializeField] private string doorDirection;

    private DungeonManager dungeonManager;

    private void Start()
    {
        dungeonManager = GameObject.FindWithTag("template").GetComponent<DungeonManager>();
        //dungeonManager.roomTab
    }
}
