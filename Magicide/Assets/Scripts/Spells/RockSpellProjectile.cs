using UnityEngine;

public class RockSpellProjectile : MonoBehaviour
{
    public GameObject RockObject;
    public Rigidbody2D playerBody;
    public float RockObjectLifeSpan = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 RockObjectPosition = playerBody.position;

        GameObject RockedObject = Instantiate(RockObject, RockObjectPosition, Quaternion.identity);


        RockedObject.GetComponent<Rigidbody2D>().linearVelocity = (playerBody.linearVelocity) * 2;
        Destroy(RockedObject, RockObjectLifeSpan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
