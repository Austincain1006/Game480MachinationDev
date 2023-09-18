using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float itemCollectionDistance = 1.5f;
    private bool _hovering;
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if (_hovering)
            if (Input.GetMouseButton(0))
            {
                var inv = _player.GetComponent<Inventory>();
                inv.CollectResource(Inventory.Resource.Wood);
                Destroy(gameObject);
            }
    }

    private void OnMouseEnter()
    {
        var distanceToPlayer = Vector3.Distance(_player.transform.position, transform.position);
        if (distanceToPlayer <= itemCollectionDistance) Hover();
    }

    private void OnMouseExit()
    {
        Unhover();
    }

    private void Hover()
    {
        _hovering = true;
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    private void Unhover()
    {
        _hovering = false;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}