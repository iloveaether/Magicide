using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

namespace Spell
{

    public class RockSpell : SpellBase
    {
        private GameObject rockSpellProjectile;

        [SerializeField]
        private float projectileSpeed = 5f;

        public RockSpell() : base(name: "Rock Spell", cooldown: 2f, isAreaOfEffect: false, damage: 20f, manaCost: 10f, type: SpellType.Earth, isChargeable: false, null)
        {
            rockSpellProjectile = Resources.Load<GameObject>("Spell/RockSpell/RockSpellProjectilePrefab");
            if (rockSpellProjectile == null)
            {
                Debug.LogError("Failed to load rockSpellProjectile prefab");
            }
        }

        // NOTE: Maybe add casting wand to properties

        // Casts the spell
        protected override void OnCast(GameObject caster)
        {
            Vector2 casterPos = caster.GetComponent<Transform>().position;

			GameObject instance = GameObject.Instantiate(rockSpellProjectile);
            instance.GetComponent<Transform>().position = casterPos;

            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mouse - casterPos;

            instance.GetComponent<Rigidbody2D>().linearVelocity = direction.normalized * projectileSpeed;
		}
    }
}
