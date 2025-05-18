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
        Flesh
    }

    // Interfaces: https://www.w3schools.com/cs/cs_interface.php
    // A reference class for all spells
    public interface ISpell
    {
        //NAME YOU DUMB FUCK
        public string Name { get; }

		// Damage of the spell
		public float Damage { get; }

		// Amount of mana consumed when cast
		public float ManaCost { get; }

		// Amount of time before casting again
		public float Cooldown { get; }

		// Is spell an area of effect spell
		public bool IsAreaOfEffect { get; }

		// The spell type of spell
		public SpellType Type { get; }

        public bool isChargeable {  get; }

		// NOTE: Maybe add casting wand to properties

		// Casts the spell
		public void Cast();
    }
}