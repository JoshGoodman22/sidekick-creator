using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public List<GameObject> AllCreatures;

    public SpriteRenderer WeaponRenderer;

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

    }
    public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }

}
