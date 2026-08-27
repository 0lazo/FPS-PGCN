using UnityEngine;
using DG.Tweening;
public class DoorCrontoller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameEvents.instance.onDoorTriggerEnter += OpenDoor;
        GameEvents.instance.onDoorTriggerExit += CloseDoor;
    }

    // Update is called once per frame
    void OpenDoor()
    {
        //transform.Translate(new Vector3(2.545f, 2.944f, 6.448f));
        transform.DOMoveY(4, 2);
    }
    
    void CloseDoor()
    {
        //transform.Translate(new Vector3(2.545f, 0.944f, 6.448f));
        transform.DOMoveY(0.944f, 2);
    }
}
