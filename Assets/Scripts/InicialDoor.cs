using DG.Tweening;
using UnityEngine;

public class InicialDoor : MonoBehaviour
{
   
    void Start()
    {
        OpenDoor();
    }

    public void OpenDoor()
    {
        transform.DOMoveY(transform.position.y + 4, 6);
    }
}
