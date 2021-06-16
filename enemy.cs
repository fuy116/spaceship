using UnityEngine;


public class enemy : MonoBehaviour
{
    
    private Rigidbody2D rb_stone;
    public float speed = 1f; //隕石移動速度
    GameObject player_gameobject;
    
 

  
    void Start()
    {
        player_gameobject = GameObject.FindGameObjectWithTag("player");
        rb_stone = GetComponent<Rigidbody2D>();
         
    }
 
    //public RigidBody2D rb_stone;
    void Update()
    {
        rb_stone.AddForce(Vector2.left*speed);
          //transform.Translate(Vector2.left*Time.deltaTime*speed);
          if(transform.position.x<-6.29f)
          {
           
              Destroy(gameObject);
          }
    }

     void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "player") //如果aaa碰撞事件的物件標籤名稱是test
        {    
           
            player_gameobject.GetComponent<player>().health_attack();//扣血
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "bullet")
        {
            player player_ = player_gameobject.GetComponent<player>();
            player_.score = player_.score + 10;
            Destroy(gameObject);

        }
    }



}
