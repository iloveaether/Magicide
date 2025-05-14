using UnityEngine;

public class InteractiveObjejctCollisionEffect : MonoBehaviour
{
    public Rigidbody2D HurtBox1Scope;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Collision started with: " + collision.gameObject.name);
        }

        void OnCollisionStay2D(Collision2D collision)
        {
            Debug.Log("Still colliding with: " + collision.gameObject.name);
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            Debug.Log("Collision ended with: " + collision.gameObject.name);
        }
    }
}
