using UnityEngine;

namespace Spell
{

    public class RockSpell : SpellBase
    {
        public RockSpellProjectile rockSpellProjectile;
        public RockSpell() : base(name: "Rock Spell", cooldown: 2f, isAreaOfEffect: false, damage: 20f, manaCost: 10f, type: SpellType.Earth, isChargeable: false, null)
        {
        }

        // NOTE: Maybe add casting wand to properties

        // Casts the spell
        protected override void OnCast()
        {

        }
    }
}
