using UnityEngine;

public class WinZone : MonoBehaviour
{
    public UpdateUi ui;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.VictoryPanel();
        }    
    }
}