using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private static Image HealthBarImage;
    public int health = 100;
    public int speed = 3;
    public GameObject healthbar;
    public GameObject bullet_shoot;
    public  int score =0;
    public Text score_text;
    GameObject scenemanager;
  

    void Start()
    {
       this.healthbar = GameObject.Find("healthbar");
       this.bullet_shoot = GameObject.Find("子彈發射點");
       this.scenemanager = GameObject.Find("場景");
    
    }
    
    void Update()
    {
        movefunction();
        score_update();
        bullet_shoot.GetComponent<bullet_generator>().shoot();

        
    }
    public void health_attack()
    {
        if(health <=0)
        {
            health = 0;
            scenemanager.GetComponent<scene_manager>().GameOver();
            
        }
        health = health - 10;
        healthbar.GetComponent<Image>().fillAmount -= 0.1f; //血條扣血
    }
    
    void score_update()
    {
        score_text.text = "分數:" + score.ToString();
    }

    void movefunction()
	{
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 Pos = transform.position;
        Pos.x +=h*Time.deltaTime*speed;
        Pos.y +=v*Time.deltaTime*speed;
        if(Pos.y<=3.5&&Pos.x>-5.8&&Pos.x<=2.5&&Pos.y>=-3.35)
        {
        transform.position = Pos;
        }
    }

}

