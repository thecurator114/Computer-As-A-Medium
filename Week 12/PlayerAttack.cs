using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [Header("References")]
    public PlayerMana manaSystem;
    public GameObject fireballPrefab;
    public Transform firePoint;

    [Header("Settings")]
    public float fireballCost = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            CastFireball();
        }
    }

    void CastFireball()
    {
        if (manaSystem != null && manaSystem.TrySpendMana(fireballCost))
        {
            Debug.Log("Fireball cast!");
        }
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
        }
    }
    void SummonObject()
    {
        if (fireballPrefab != null)
        {
            Instantiate(fireballPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Didn't Work");
        }
    }
}
