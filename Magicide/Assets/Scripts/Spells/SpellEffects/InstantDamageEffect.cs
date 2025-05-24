using Spell;
using UnityEngine;

namespace Spell
{
    public class InstantDamageEffect : ISpellEffect
    {
        private float damage;
        public float Duration { get => 0; }

        public bool IsImmediate { get => true; }

        public InstantDamageEffect(float damage = 25f)
        {
            this.damage = damage;
        }

        public void Apply(PlayerManager manager)
        {
            manager.Current_health -= damage;
        }
    }
}
