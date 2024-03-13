using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonScript : MonoBehaviour
{
    public float Health = 30;    
      
    public float Damage = 10;

    public TMPro.TextMeshProUGUI HealthText;

    public Animator Animator;
    
    public void TakingDamage()
    {
        if (Scene.Instance.State == 1)
        {

            //hasar alma
             Health -=MainCharacter.Instance.Damage+ MainCharacter.Instance.ExtraDamage;
             HealthText.text = Health.ToString();

            //tur atlama
            Scene.Instance.State = 2;

            //ölme
            if (Health < 1)
             {
                 gameObject.SetActive(false);
                Scene.Instance.EnemyNumber -= 1;
             }

            
        }
    }
}
