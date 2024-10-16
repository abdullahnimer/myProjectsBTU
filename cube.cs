using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using JetBrains.Annotations;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame updatep    //[SerializeField]
    private float speed=1.0f;   //set speed deafult defien private 
    public float userSpeed=1.0f; //set user speed deafult defien inside and next set data outside
    public bool moveRightLeft=false; //user tarafindan sag sol yonlerde hareket yapiyor istiyorsa
   
    void Start()
    {
        transform.position =new Vector3(0,0,0); //set position ilk kare
    }
 
    public void Update()
    {
         //move just to one vector up down & set speed from user using default or number of speed........
       transform.position += new Vector3(0,(Input.GetAxis("Vertical") )*speed*Time.deltaTime,0 );
       
       //public speed from user using for( x,y up down right left)//float speed=1.0f;deafult & example: user from set speed=5.0f; 
       
       if (moveRightLeft)
       {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*userSpeed,
                                            (Input.GetAxis("Vertical") )*userSpeed*Time.deltaTime,0 );
       } 
       else{
         //move just to one vector up down & set speed from user using default or number of speed........

         transform.position += new Vector3(0,(Input.GetAxis("Vertical") )*userSpeed*Time.deltaTime,0 );
       }
   }
  
}
