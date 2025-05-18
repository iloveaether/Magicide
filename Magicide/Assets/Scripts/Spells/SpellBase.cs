using UnityEngine;


namespace Spell
{
	// A base template for standard spells
	// This could be inherited from to reduce a bunch of reused code and make it easier to code new spells
	// Use this unless you need to make a completely custom spell
	public abstract class SpellBase : ISpell
	{
		// The last time this spell was casted
		protected float lastCastTime;

		// Cooldown for the spell to be casted again
		protected float cooldown;

		protected ISpellEffect[] spellEffects;

		protected string name;

		protected float damage;

		protected float manaCost;

		protected bool isAreaOfEffect;

		protected SpellType type;

		protected bool isChargeable;

		string ISpell.Name { get => name; }
		float ISpell.Damage { get => damage; }
		float ISpell.ManaCost { get => manaCost; }
		float ISpell.Cooldown { get => cooldown; }
		bool ISpell.IsAreaOfEffect { get => isAreaOfEffect; }
		SpellType ISpell.Type { get => type; }
		bool ISpell.isChargeable { get => isChargeable; }
		
		
		protected SpellBase(string name, float cooldown, bool isAreaOfEffect, float damage, float manaCost, SpellType type, bool isChargeable, ISpellEffect[] spellEffects)
		{
			this.name = name;
			this.cooldown = cooldown;
			this.cooldown = cooldown;
			this.isAreaOfEffect = isAreaOfEffect;
			this.damage = damage;
			this.manaCost = manaCost;
			this.type = type;
			this.spellEffects = spellEffects;
			this.lastCastTime = 0f;
			this.isChargeable = isChargeable;
		}

		public virtual bool CanCast()
		{
			if (Time.time - lastCastTime > cooldown)
				return true;
			return false;
		}

		// This function is called to cast the spell
		public virtual void Cast()
		{
			if (!CanCast())
				return;
			OnCast();
			lastCastTime = Time.time;
		}

		// The stuff that actually casts it
		protected abstract void OnCast();
	}
}