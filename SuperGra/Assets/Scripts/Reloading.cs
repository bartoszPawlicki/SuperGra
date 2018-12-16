using UnityEngine;
using System.Collections;

public class Reloading : MonoBehaviour
{
    public int MagazineCapacity;
    public int ammoInMagazine;

    public int ammoRemaining;
    public bool canFire;

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(5);
        canFire = true;
    }

    void Start()
    {
        canFire = true;
    }

    void Update()
    {
        if (ammoInMagazine <= 0)
        {
            if (ammoRemaining >= ammoInMagazine)
            {
                StartCoroutine("Reload");
                if (ammoRemaining >= MagazineCapacity)
                {
                    ammoRemaining -= MagazineCapacity;
                    ammoInMagazine = MagazineCapacity;
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



