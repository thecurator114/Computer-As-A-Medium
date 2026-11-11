using UnityEngine;
using UnityEngine.Input System;
using PlayerMana

public class PlayerAttack : MonoBehaviour
{
    public ManaSystem manaSystem;
    public float fireballCost = 10f;

    void Update()
    {
        if(Input.GetKeyDown (Keycode.f))
        {
            CastFireball();
        }
    }
    void CastFireball()
    {
        if (manaSystem.TrySpendMana(fireballCost))
        {
            Debug.Log("Firball cast!");
        }
    }
}
