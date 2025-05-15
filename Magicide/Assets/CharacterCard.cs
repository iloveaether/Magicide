using UnityEngine;

public class CharacterCard : MonoBehaviour
{
    public class Character
    {
        public string name;
        public float health;
        public float mana;
        public float speed;
    }

    public Character John = new Character
    {
        name = "Stupid Poopyhead",
        health = 100f,
        mana = 100f,
        speed = 100f
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Character: {John.name}, Health: {John.health}, Mana: {John.mana}, Speed: {John.speed}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
