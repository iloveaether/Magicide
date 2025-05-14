using UnityEngine;

public class InteractiveObjectScriptTEST : MonoBehaviour
{
    public BoxCollider2D ColliderHurtBox;
    private SpriteRenderer ColliderSr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the SpriteRenderer component attached to this GameObject
        ColliderSr = GetComponent<SpriteRenderer>();

        // Get the BoxCollider2D if not assigned in Inspector

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        ColliderSr.color = Color.green; // Change color to green when player enters
    }
}
