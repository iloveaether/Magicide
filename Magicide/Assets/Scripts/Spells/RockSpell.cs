using UnityEngine;

namespace Spell
{

    public class RockSpell : SpellBase
    {
        public GameObject RockObject;
        public Rigidbody2D playerBody;
        public float RockObjectLifeSpan = 2f;

        public RockSpell() : base(name: "Rock Spell", cooldown: 2f, isAreaOfEffect: false, damage: 20f, manaCost: 10f, type: SpellType.Earth, isChargeable: false, null)
        {
        }

        // NOTE: Maybe add casting wand to properties

        // Casts the spell
        protected override void OnCast()
        {
            Vector2 RockObjectPosition = playerBody.position;

            GameObject RockObject = Instantiate(RockObject, RockObjectPosition, Quaternion.identity);


            AppearedObject.GetComponent<Rigidbody2D>().linearVelocity = (playerBody.linearVelocity) * 2;
            Destroy(RockdObject, RockObjectLifeSpan);
        }
    }
}
