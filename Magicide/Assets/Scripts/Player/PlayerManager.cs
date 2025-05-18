using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CharacterStats characterStats;

    public Spell.SpellBase spell1;

    public Spell.SpellBase spell2;

    public Spell.SpellBase spell3;


    private float current_health;

    private float current_mana;

    public float current_move_speed;

    public float sprintMultiplier;

    public float tiredSpeedMultiplier;

    public float current_stamina;

    public float max_stamina;

    public float staminaRechargeRate;

    public float staminaConsumptionRate;



    void Start()
    {
        characterStats = new CharacterStats();
        spell1 = characterStats.spell1;
        spell2 = characterStats.spell2;
        spell3 = characterStats.spell3;
        current_health = characterStats.MaxHealth;
        current_mana = characterStats.MaxMana;
        current_move_speed = characterStats.MoveSpeed;
        current_stamina = characterStats.MaxStamina;
        max_stamina = characterStats.MaxStamina;
        staminaRechargeRate = characterStats.StaminaRechargeRate;
        staminaConsumptionRate = characterStats.StaminaConsumptionRate;
        sprintMultiplier = characterStats.SprintMultiplier;
        tiredSpeedMultiplier = characterStats.TiredSpeedMultiplier;
        Debug.Log("IM ALIVE (MANAGER)");
    }
}