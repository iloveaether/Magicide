using NUnit.Framework;
using Spell;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CharacterStats characterStats;

    public Spell.SpellBase spell1;

    public Spell.SpellBase spell2;

    public Spell.SpellBase spell3;


    private float current_health;

    private float current_mana;

    private float current_move_speed;

	private float sprintMultiplier;

	private float tiredSpeedMultiplier;

	private float current_stamina;

	private float max_stamina;

	private float staminaRechargeRate;

	private float staminaConsumptionRate;

	private List<ISpellEffect> currentEffects;



	public float Current_health { get => current_health; set => current_health = value; }

	public float Current_mana { get => current_mana; set => current_mana = value; }

	public float Current_move_speed { get => current_move_speed; set => current_move_speed = value; }

	public float SprintMultiplier { get => sprintMultiplier; set => sprintMultiplier = value; }

	public float TiredSpeedMultiplier { get => tiredSpeedMultiplier; set => tiredSpeedMultiplier = value; }

	public float Current_stamina { get => current_stamina; set => current_stamina = value; }

	public float Max_stamina { get => max_stamina; set => max_stamina = value; }

	public float StaminaRechargeRate { get => staminaRechargeRate; set => current_health = value; }

	public float StaminaConsumptionRate { get => staminaConsumptionRate; set => staminaConsumptionRate = value; }


	

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

        currentEffects = new List<ISpellEffect>();

        Debug.Log("IM ALIVE (MANAGER)");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            spell1.Cast(gameObject);
        }
        DoEffects();
    }

    public void ApplyEffect(Spell.ISpellEffect effect)
    {
        if (effect.IsImmediate)
        {
            effect.Apply(this);
        }
        else
        {
            currentEffects.Add(effect);
        }
    }

    private void DoEffects()
    {
        for (int i=0; i < currentEffects.Count; i++)
        {
            ISpellEffect effect = currentEffects[i];

            // Apply effects to the player
            effect.Apply(this);

            if (effect.Duration <= 0)
            {
                // Remove effect if it's duration is out
                currentEffects.RemoveAt(i);
                i--;
            }
        }
    }
}