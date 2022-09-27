using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public MeshRenderer imageToRender;
    public GameObject attackPoint1;
    public GameObject attackPoint2;
    public GameObject attackPoint3;

    public void ChangeImageToRender(Material imageMat)
    {
        imageToRender.material = imageMat;
    }

    public void SetAttackPoints(AttackCategory category)
    {
        attackPoint1.SetActive(false);
        attackPoint2.SetActive(false);
        attackPoint3.SetActive(false);
        
        switch (category)
        {
            case AttackCategory.One:
                attackPoint1.SetActive(true);
                break;
            case AttackCategory.Two:
                attackPoint1.SetActive(true);
                attackPoint2.SetActive(true);
                break;
            case AttackCategory.Three:
                attackPoint1.SetActive(true);
                attackPoint2.SetActive(true);
                attackPoint3.SetActive(true);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(category), category, null);
        }
    }

    public enum AttackCategory
    {
        One,
        Two,
        Three
    }
}
