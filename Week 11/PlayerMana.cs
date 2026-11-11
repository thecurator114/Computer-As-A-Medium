using UnityEngine;
using UnityEngine.UI;

public class PlayerMana : MonoBehaviour
{
    [Header("Mana Settings")]
    public float maxMana = 100f;
    public float currentMana;
    public float manaRegenRate = 5f;

    [Header("UI Reference")]
    public Slider manaSlider;

    void Start()
    {
        currentMana = maxMana;
        if (manaSlider != null)
        {
            manaSlider.maxValue = maxMana;
            manaSlider.value = currentMana;
        }
    }
    void Update()
    {
        if (currentMana < maxMana)
        {
            currentMana += manaRegenRate * Time.deltaTime;
            currentMana = Mathf.clamp(currentMana, 0f, maxMana);
            UpdateManaUI(;)
        }
    }
    public bool TrySpendMana(float amount)
    {
        if (currentMana >= amount)
        {
            currentMana -= amount;
            UpdateManaUI();
            return true;
        }
        return false;
    }
    private void UpdateManaUI()
    {
        if (manaSlider != null)
        {
            manaSlider.value = currentMana
        }
    }
}
