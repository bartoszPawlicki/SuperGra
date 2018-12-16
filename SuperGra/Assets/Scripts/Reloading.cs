using UnityEngine;
using System.Collections;

public class Reloading : MonoBehaviour
{
    public int magazineCapacity;
    public int ammoInMagazine;

    public int ammoRemaining;

    [HideInInspector]
    public bool canFire = true;

    IEnumerator Reload()
    {
        canFire = false;
        yield return new WaitForSeconds(2);
        canFire = true;
    }

    void Update()
    {
        if (ammoInMagazine <= 0)
        {
            if (ammoRemaining >= ammoInMagazine)
            {
                StartCoroutine("Reload");
                if (ammoRemaining >= magazineCapacity)
                {
                    ammoRemaining -= magazineCapacity;
                    ammoInMagazine = magazineCapacity;
                }
                else
                {
                    ammoInMagazine = ammoRemaining;
                    ammoRemaining = 0;
                }

            }
        }
    }
}



