using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{

    public InputField currentAmmoField;
    public InputField carriedAmmoField;

    void UpdateAmmoUI(int currentAmmo, int carriedAmmo)
    {
        if (currentAmmoField != null)
        {
            currentAmmoField.text = currentAmmo.ToString();
        }
        if (carriedAmmoField != null)
        {
            carriedAmmoField.text = carriedAmmo.ToString();
        }
    }
}
       