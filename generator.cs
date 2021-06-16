using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
      public GameObject enemy_gameObject;

        public float Ins_Time = 2f;
        public int aMax = 4;//x軸生成range max value
        public int aMin = -4;

    void Start()
    {
        InvokeRepeating("spawn", 3, Ins_Time);
        //函式名稱,第一次開始間隔時間,間隔時間
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        int Random_Points = Random.Range(aMin,aMax);
        Instantiate(enemy_gameObject,new Vector2(6.39f,Random_Points),Quaternion.identity);
    }
}
