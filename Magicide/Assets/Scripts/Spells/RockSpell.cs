using UnityEngine;

namespace Spell
{

    public class RockSpell : SpellBase
    {
        public GameObject rockSpellProjectile;
        public RockSpell() : base(name: "Rock Spell", cooldown: 2f, isAreaOfEffect: false, damage: 20f, manaCost: 10f, type: SpellType.Earth, isChargeable: false, null)
        {
            rockSpellProjectile = Resources.Load<GameObject>("Spell/RockSpell/RockSpellProjectilePrefab");
            if (rockSpellProjectile != null)
            {
                Debug.LogError("Failed to load rockSpellProjectile prefab");
            }
        }

        // NOTE: Maybe add casting wand to properties

        // Casts the spell
        protected override void OnCast()
        {
			GameObject instance = GameObject.Instantiate(rockSpellProjectile);
		}
    }
}
