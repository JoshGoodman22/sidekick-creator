using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public List<GameObject> AllCreatures;

    public SpriteRenderer WeaponRenderer;

    public GameObject Fighter;

    public void SetCreature(GameObject creature)
    {
        
        foreach (GameObject obj in AllCreatures)
        {
            if (obj == creature)
            {
                obj.SetActive(true);
            }
            else
            {
                obj.SetActive(false);
            }
        }

        if (Fighter.activeInHierarchy)
        {
            WeaponRenderer.gameObject.transform.position = new Vector2(1.450f, .590f);
        }
        else 
        {
            WeaponRenderer.gameObject.transform.position = new Vector2(1.603f, 0.695f);
        }

    }
    public void SetWeapon(Sprite newSprite)
    {
        if (Fighter.activeInHierarchy) {
            WeaponRenderer.gameObject.transform.position = new Vector2(1.450f, .590f);
        } else {
            WeaponRenderer.gameObject.transform.position = new Vector2(1.603f, 0.695f);

        }
        WeaponRenderer.sprite = newSprite;
    }

}
