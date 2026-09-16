using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    public GameObject Leftdoor;
    public GameObject Rightdoor;

    public void OpenFinalDoors()
    {
        Leftdoor.transform.DOMoveX(Leftdoor.transform.position.x - 3, 10);
        Rightdoor.transform.DOMoveX(Rightdoor.transform.position.x + 3, 10);
    }
}
