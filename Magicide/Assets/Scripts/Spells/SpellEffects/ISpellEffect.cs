using System.IO;
using UnityEngine;

namespace Spell
{
    // ISpellEffect is an interface for effects applied to players from spells
    // Such as such as damage, poison, burning, healing, etc.
    public interface ISpellEffect
    {
        // Current duration the spell is to be applied to the player. Before it is applied it is the max duration
        public float Duration { get; }

        // If the spell is `immediate` (applied only once immediately)
        public bool IsImmediate { get; }

        // Applies the effect to the player
        public void Apply(PlayerManager player);

    }
}
