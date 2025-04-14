using UnityEngine;

public class DungeonManager : MonoBehaviour
{
    // Tab de toutes les salles
    [SerializeField] private GameObject[] roomTab;

    //Nb de salle Spawned
    private int spawnedRooms;

    // Nb salle max
    [SerializeField] private int maxRooms = 20;

    // Style du hub 
    private GUIStyle style;

    private void OnGUI()
    {
        // Paramétrage 
        style = new GUIStyle(GUI.skin.box);
        style.alignment = TextAnchor.MiddleLeft;
        style.padding.left = 10;

        // Affichage
        GUI.Box(new Rect(10, 10, 200, 60), "Nbr total salle : " + maxRooms + "\n","nbr salle spawned : " + style); 

    }
}
