using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // if (other.CompareTag("Item")) 
        Debug.Log("item enter");
    }
}