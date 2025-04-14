using UnityEngine;
using System.Text.RegularExpressions;

public class RegExp : MonoBehaviour
{
    string codepostal = "31320";

    string modèle = "^31000$"; 

    /*
     
    ^       début du modèle
    $       fin du modèle

    x|y     je veux "x" ou "y"
    .       nimporte quel caractère
    \.      caractère d'échappement

    {n}     n fois le caractère qui précède
    {n, }   n fois le charactère qui précède au minimum
    {n, m}  n caractère minimum, m maximum

    */

    private void Start()
    {
        
        bool test1 = Regex.IsMatch(codepostal, modèle);

        if (test1) { Debug.Log("Match"); }
        else { Debug.Log("Match pas"); }

    }
}
