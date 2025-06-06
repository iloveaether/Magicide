using UnityEngine;

// Contains information about a player's character stats
public class CharacterStats
{
	// blank spell inventory for player
	public Spell.SpellBase spell1 = new Spell.RockSpell();

	public Spell.SpellBase spell2 = null;

	public Spell.SpellBase spell3 = null;

	public Spell.SpellBase spell4 = null;

	// How much mana the player has
	[SerializeField]
	private float maxMana = 0;

	// How much health the player has
	[SerializeField]
	private float maxHealth = 0;

	// How fast a player can move in a direction
	[SerializeField]
	private float moveSpeed = 5f;

	// Multiplied to a player's movement when sprinting
	[SerializeField]
	private float sprintMultiplier = 2f;

	// How slowed a player walks when tired
	[SerializeField]
	private float tiredSpeedMultiplier = 0.75f;

	// The maximum amount of stamina a player can have
	[SerializeField]
	private float maxStamina = 2f;

	// The rate stamina is consumed when running
	[SerializeField]
	private float staminaConsumptionRate = 0.5f;

	// The rate stamina is recharged when not running
	[SerializeField]
	private float staminaRechargeRate = 0.75f;

	public float MoveSpeed{ get => moveSpeed; }
	public float SprintMultiplier { get => sprintMultiplier; }
	public float TiredSpeedMultiplier { get => tiredSpeedMultiplier; }
	public float MaxHealth {  get => maxHealth; }
	public float MaxMana { get => maxMana; }
	public float MaxStamina { get => maxStamina; }
	public float StaminaConsumptionRate { get => staminaConsumptionRate; }
	public float StaminaRechargeRate { get => staminaRechargeRate; }

	private void Start()
	{
	}
}
