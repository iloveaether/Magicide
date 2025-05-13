using UnityEngine;

public class SquareBodyScript : MonoBehaviour
{
    public Rigidbody2D SquareBody;
    public float CharacterStamina = 2f;
    public float moveSpeed = 5f;
    private bool isTired = false; 
    
    public static void DivaLog(object DivaAhh)
    {
        Debug.Log(DivaAhh);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics2D.gravity = Vector2.zero;

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        float movementMultiplier = 1;

        if (Input.GetKey(KeyCode.W)) moveY += 1;
        if (Input.GetKey(KeyCode.S)) moveY -= 1;
        if (Input.GetKey(KeyCode.A)) moveX -= 1;
        if (Input.GetKey(KeyCode.D)) moveX += 1;

        if (CharacterStamina > 0.5f && isTired) {isTired = false; DivaLog("No more tired"); }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (CharacterStamina > 0f)
            {
                movementMultiplier = 2;
                CharacterStamina -= 0.75f * Time.deltaTime;


            }
            else if (CharacterStamina == 0f)
            {
                isTired = true;
                DivaLog("Tired cause ran too much");
            }
            else CharacterStamina = 0f;

        }
        else
        {
            CharacterStamina += 0.5f * Time.deltaTime;

            if (isTired == true)
            {
                movementMultiplier = 0.75f;
                DivaLog("Slow cause tired");
            }
        }

        CharacterStamina = Mathf.Clamp(CharacterStamina, 0f, 2f);

        SquareBody.linearVelocity = new Vector2(moveX, moveY) * moveSpeed * movementMultiplier;







    }
}
