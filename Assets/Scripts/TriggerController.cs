using UnityEngine;

public class TriggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEvents.instance.OpenTriggerDoor();
        
    }

    private void OnTriggerExit(Collider other)
    {
        GameEvents.instance.CloseTriggerDoor();
    }
}
