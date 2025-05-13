using UnityEngine;

namespace Spell
{

    public class RockSpell : ISpell
    {
        //NAME YOU DUMB FUCK
        private string name = "Rock Spell";

        // Damage of the spell
        private float damage = 20f;

        // Amount of mana consumed when cast
        private float manaCost = 10f;

        // Amount of time before you can cast again
        private float castTime = 2f;

        // Is spell an area of affect spell
        bool isAreaOfAffect = false;

        // The spell type of spell
        SpellType Type { get => type; }

		public string Name => name;

		public float Damage => damage;

		public float ManaCost => manaCost;

		public float CastTime => castTime;

		public bool IsAreaOfAffect => isAreaOfAffect;

		string ISpell.Name => name;

		float ISpell.Damage => damage;

		float ISpell.ManaCost => manaCost;

		float ISpell.CastTime => castTime;

		bool ISpell.IsAreaOfAffect => isAreaOfAffect;

		SpellType ISpell.Type => Type;

		SpellType type = SpellType.Earth;

        // NOTE: Maybe add casting wand to properties

        // Casts the spell
        void Cast()
        { 
            //Essentially just create a projectile with hurt box, player manager will handle damage and player based effects.
        }

		void ISpell.Cast()
		{
			Cast();
		}
	}
}
