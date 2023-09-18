using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum Resource
    {
        Wood,
        Stone,
        Iron,
        Silver
    }

    public Dictionary<Resource, int> Resources = new()
    {
        { Resource.Wood, 0 },
        { Resource.Stone, 0 },
        { Resource.Iron, 0 },
        { Resource.Silver, 0 }
    };

    public void CollectResource(Resource resource)
    {
        var was = Resources[resource];
        Resources[resource]++;
        Debug.Log(resource + " was: " + was + ", now: " + Resources[resource]);
    }
}