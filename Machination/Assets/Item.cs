using UnityEngine;

public class Item : MonoBehaviour
{
    public CollectionRange collectionRange;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseEnter()
    {
        if (collectionRange.playerInRange) Debug.Log("Mouse enter, in range");
    }
}