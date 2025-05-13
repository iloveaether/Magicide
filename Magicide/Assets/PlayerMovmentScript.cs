using UnityEngine;

public class PlayerMovmentScript : MonoBehaviour
{
	// How fast a player can move in a direction
	public float moveSpeed = 5f;

	// Multiplied to a player's movement when sprinting
	public float sprintMultiplier = 2f;

	// How slowed a player walks when tired
	public float tiredSpeedMultiplier = 0.75f;

	// The maximum amount of stamina a player can have
	public float maxStamina = 2f;

	// The current amount of stamina a player has
	public float characterStamina = 2f;

	// The rate stamina is consumed when running
	public float staminaConsumptionRate = 0.5f;

	// The rate stamina is recharged when not running
	public float staminaRechargeRate = 0.75f;

	// If the player is tired or not
	private bool isTired = false;

	// The Player's rigidbody
	private Rigidbody2D playerBody;

	public static void DivaLog(object DivaAhh)
	{
		Debug.Log(DivaAhh);
	}

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		playerBody = GetComponent<Rigidbody2D>(); // get the rigidbody of the gameobject this script is attached to
	}

	// Update is called once per frame
	void Update()
	{
		Vector2 playerMove = Vector2.zero; // start inputs at zero
		float movementMultiplier = 1;

		// Use Input.GetAxis to get the player input
		// This allows the player to change their keybinds later on, or use a controller

		playerMove.x = Input.GetAxis("Horizontal");
		playerMove.y = Input.GetAxis("Vertical");

		// Reset tired attribute when stamina recharges to a certain amount
		if (characterStamina > 0.5f && isTired)
		{
			isTired = false;
			DivaLog("No more tired");
		}

		if (Input.GetKey(KeyCode.LeftShift))
		{
			if (characterStamina > 0f && isTired == false)
			{
				movementMultiplier = sprintMultiplier;
				characterStamina -= staminaConsumptionRate * Time.deltaTime;
			}
			else if (characterStamina == 0f) // become tired when stamina depletes
			{
				isTired = true;
				DivaLog("Tired cause ran too much");
			}
		}
		else
		{
			characterStamina += staminaRechargeRate * Time.deltaTime; // recharge stamina when not sprinting

			// Only check if tired when not running
			// This allows you to "run" when you're tired, but only at the same speed as walking
			// However, you will not gain stamina when running while tired
			if (isTired)
			{
				movementMultiplier = tiredSpeedMultiplier;
				DivaLog("Slow cause tired");
			}
		}

		// Keep stamina between max stamina and 0
		characterStamina = Mathf.Clamp(characterStamina, 0f, maxStamina);

		// apply movement
		playerBody.linearVelocity = playerMove * moveSpeed * movementMultiplier;
	}
}
