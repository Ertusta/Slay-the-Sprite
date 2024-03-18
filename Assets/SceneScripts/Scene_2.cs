using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;

public class Scene_2 : MonoBehaviour
{
    public static Scene_2 Instance;
    //public float State;
    public float EnemyNumber=1;

    public bool Stop=true;

    public GameObject wizard;

    public Animator animator;

    public float count=0;

    

    public TMPro.TextMeshProUGUI HealthText;
    void Start()
    {
        
        Instance=this;
    }

    
    void Update()
    {
        //wizard attack
        if (MainCharacter.Instance.state==3 && Stop)
        {
            animator.SetFloat("State", 1);
            Invoke("StopWizard",1);
            Stop=false;

            
        }
    }

    void StopWizard()
    {
        animator.SetFloat("State",0 );
        MainCharacter.Instance.state = 0;
        Stop= true;
        MainCharacter.Instance.Health -= 20;
        HealthText.text = MainCharacter.Instance.Health.ToString();
        count++;
 
        if(count>=2)
        {
            wizardExtraDamage();
        }   
            

    }

    void wizardExtraDamage()
    {
        MainCharacter.Instance.Health-=5;
    }

    
    
}
