using UnityEngine;

public class MakeTriangleAppearTEST : MonoBehaviour
{
    public GameObject AppearingObject;
    public Rigidbody2D playerBody;
    public float AppearingObjectLifeSpan = 2f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { }
        



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            Vector2 AppearingObjectPosition = playerBody.position;

            GameObject AppearedObject = Instantiate(AppearingObject, AppearingObjectPosition, Quaternion.identity);


            AppearedObject.GetComponent<Rigidbody2D>().linearVelocity = (playerBody.linearVelocity) * 2;
            Destroy(AppearedObject, AppearingObjectLifeSpan);

        }

    }
}

