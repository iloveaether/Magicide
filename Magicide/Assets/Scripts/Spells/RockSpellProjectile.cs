using Spell;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class RockSpellProjectile : SpellProjectile
{
    // the time the rock was casted, so we can delete if after it's lifespan has elapsed
    private float castedTime;

    private Collider2D projectileCollider;

    public GameObject caster;
    public float RockObjectLifeSpan = 2f;

    private List<ISpellEffect> effects;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        castedTime = Time.time;
        projectileCollider = GetComponent<Collider2D>();

        this.effects = new List<ISpellEffect>();
        this.effects.Add(new InstantDamageEffect());
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - castedTime > RockObjectLifeSpan)
        {
            Destroy(gameObject);
            return;
        }
    }

	private void OnTriggerEnter2D(Collider2D collider)
	{
        Debug.Log("Intersect!");
        if (collider.gameObject != caster && collider.gameObject.GetComponent<PlayerManager>())
        {
            PlayerManager player = collider.gameObject.GetComponent<PlayerManager>();

            foreach (ISpellEffect effect in effects)
            {
                player.ApplyEffect(effect);
            }
        } 
	}
}
