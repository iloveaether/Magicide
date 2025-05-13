using UnityEngine;

namespace Spell;

public class RockSpell
{
    //NAME YOU DUMB FUCK
    string Name { get => name; }
    private string name = "Rock Spell";

    // Damage of the spell
    float Damage { get => damage; }
    private float damage = 20f;

    // Amount of mana consumed when cast
    float ManaCost { get => manaCost; }
    private float manaCost = 10f;

    // Amount of time before you can cast again
    float CastTime { get => castTime; }
    private float castTime = 2f;

    // Is spell an area of affect spell
    bool IsAreaOfAffect { get => isAreaOfAffect; }
    bool isAreaOfAffect = false;

    // The spell type of spell
    SpellType Type { get => type; }
    SpellType type = Earth;

    // NOTE: Maybe add casting wand to properties

    // Casts the spell
    void Cast();
}

