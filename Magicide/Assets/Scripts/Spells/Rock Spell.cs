using UnityEngine;

namespace Spell
{

    public class RockSpell : SpellBase
    {
        public RockSpell() : base(name: "Rock Spell", cooldown: 2f, isAreaOfEffect: false, damage: 20f, manaCost: 10f, type: SpellType.Earth, null)
        {
        }

        // NOTE: Maybe add casting wand to properties

        // Casts the spell
        protected override void OnCast()
        { 
            //Essentially just create a projectile with hurt box, player manager will handle damage and player based effects.
        }
	}
}
