using UnityEngine;

public class MakeTriangleAppearTEST : MonoBehaviour
{
    public GameObject AppearingObject;
    public Rigidbody2D playerBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Vector2 AppearingObjectPosition = playerBody.position;

            Instantiate(AppearingObject, AppearingObjectPosition, Quaternion.identity);
        }
            
    }
}
