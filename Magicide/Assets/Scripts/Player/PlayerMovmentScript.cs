using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovmentScript : MonoBehaviour
{
	// If the player is tired or not
	private bool isTired = false;

	// The current amount of stamina a player has
	private float characterStamina = 2f;

	// The Player's rigidbody
	public Rigidbody2D playerBody;

	// reference to the player manager
	private PlayerManager playerManager;

	public static void DivaLog(object DivaAhh)
	{
		Debug.Log(DivaAhh);
	}

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		playerBody = GetComponent<Rigidbody2D>(); // get the rigidbody of the gameobject this script is attached to
		playerManager = GetComponent<PlayerManager>(); // get the player stats of the gameobject this script is attached to
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
				movementMultiplier = playerManager.SprintMultiplier;
				characterStamina -= playerManager.StaminaConsumptionRate * Time.deltaTime;
			}
			else if (characterStamina == 0f) // become tired when stamina depletes
			{
				isTired = true;
				DivaLog("Tired cause ran too much");
			}
		}
		else
		{
			characterStamina += playerManager.StaminaRechargeRate * Time.deltaTime; // recharge stamina when not sprinting

			// Only check if tired when not running
			// This allows you to "run" when you're tired, but only at the same speed as walking
			// However, you will not gain stamina when running while tired
			if (isTired)
			{
				movementMultiplier = playerManager.TiredSpeedMultiplier;
				DivaLog("Slow cause tired");
			}
		}

		// Keep stamina between max stamina and 0
		characterStamina = Mathf.Clamp(characterStamina, 0f, playerManager.Max_stamina);

		if (playerMove != Vector2.zero)
		{
			// Normalize speed of the player to prevent them from moving twice as fast diagonal
			var temp = playerMove.Abs();
			playerMove.Normalize();
			playerMove.Scale(new Vector2(temp.x, temp.y));
		}

		// apply movement
		playerBody.linearVelocity = playerMove * playerManager.Current_move_speed * movementMultiplier;

	}
}
