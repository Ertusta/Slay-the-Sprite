using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class wizard : MonoBehaviour
{
    
    public float Health=60;

    public float damage=20;

    public TMPro.TextMeshProUGUI HealthText;

    public Animator animator;

     public void TakingDamage()
    {

        if(MainCharacter.Instance.state==0f )
        {
            Health-=MainCharacter.Instance.Damage;
            HealthText.text = Health.ToString();

            MainCharacter.Instance.state=2f;

            if (Health < 1)
            {
                gameObject.SetActive(false);
                Scene.Instance.EnemyNumber -= 1;
            }


        }
        if (MainCharacter.Instance.state == 1)
        {

            
            Health -=MainCharacter.Instance.Damage+ MainCharacter.Instance.ExtraDamage;
            HealthText.text = Health.ToString();

            
            MainCharacter.Instance.state = 2;

            
            if (Health < 1)
            {
                gameObject.SetActive(false);
                Scene_2.Instance.EnemyNumber -= 1;
            }

            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
