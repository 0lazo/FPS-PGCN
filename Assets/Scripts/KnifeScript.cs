using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerHealth>().TakeDamage(5);
    }
}
