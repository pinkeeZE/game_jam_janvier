using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personnages : MonoBehaviour
{
    
    /* creation de la classe object humanoids*/
    public class Humanoids 
    {
        public Humanoids(string name, float pv, float stamina, float weight,float speed)
        {
            Name = name;
            Pv = pv;
            Stamina = stamina;
            Weight = weight;
            Speed = speed;
        }

        //methodes
        


        //attributs
        public string Name;
        public float Pv;
        public float Stamina;
        public float Weight;
        public float Speed;


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
