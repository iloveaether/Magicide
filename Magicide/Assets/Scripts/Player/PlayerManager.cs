using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CharacterStats characterStats;

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