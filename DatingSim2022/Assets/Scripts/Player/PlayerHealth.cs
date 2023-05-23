using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealt;
    private float tempHealth;

    private void Start()
    {
        if (PlayerPrefs.GetFloat("PlayerHealth") != maxHealt)
        {
            tempHealth = PlayerPrefs.GetFloat("PlayerHealth");
        }
        else
        {
            tempHealth = maxHealt;
        }
    }

    public void Damage(float value)
    {
        tempHealth -= value;
        PlayerPrefs.SetFloat("PlayerHealth", tempHealth);

        if(tempHealth <= 1)
        {
            PlayerPrefs.SetFloat("PlayerHealth", maxHealt);
            //die
        }
    }

    public void Heal(float value)
    {
        tempHealth += value;
        PlayerPrefs.SetFloat("PlayerHealth", tempHealth);

        if(tempHealth >= maxHealt)
        {
            tempHealth = maxHealt;
            PlayerPrefs.SetFloat("PlayerHealth", tempHealth);
        }
    }
}