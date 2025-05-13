using UnityEngine;

namespace Spell
{
    // The types of spells
    public enum SpellType
    {
        None = 0,
        Fire,
        Water,
        Earth,
        Air,
        Lightning,
        Space,
        Time,
        Shadow,
        Light,
        Heal
    }

    // Interfaces: https://www.w3schools.com/cs/cs_interface.php
    // A reference class for all spells
    public interface ISpell
    {
        //NAME YOU DUMB FUCK
        string Name { get; }

        // Damage of the spell
        float Damage { get; }

        // Amount of mana consumed when cast
        float ManaCost { get; }

        // Amount of time taken when casting
        float CastTime { get; }

        // Is spell an area of affect spell
        bool IsAreaOfAffect { get; }

        // The spell type of spell
        SpellType Type { get; }

        // NOTE: Maybe add casting wand to properties

        // Casts the spell
        void Cast();
    }

}