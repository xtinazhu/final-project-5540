using UnityEngine;

public class KeyPickupBehavior : MonoBehaviour
{
    public GameObject prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyPickup()
    {
        Destroy(gameObject);
    }
}
