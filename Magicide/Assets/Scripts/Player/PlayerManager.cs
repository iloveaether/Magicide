using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CharacterStats characterStats;

    private float current_health;

    private float current_mana;

    public float current_move_speed;

    public float current_stamina;


    void Start()
    {
        characterStats = new CharacterStats();
        current_health = characterStats.MaxHealth;
        current_mana = characterStats.MaxMana;
        current_move_speed = characterStats.MoveSpeed;
        current_stamina = characterStats.MaxStamina;
    }
}