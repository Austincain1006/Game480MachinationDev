using UnityEngine;

public class CollectionRange : MonoBehaviour
{
    public bool playerInRange;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) playerInRange = true;
        Debug.Log("enter");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) playerInRange = false;
        Debug.Log("exit");
    }
}