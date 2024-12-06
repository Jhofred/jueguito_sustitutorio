using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Mapa;
    public Renderer fondo;
    public  List<GameObject> cols;
    public GameObject zom01;

    

    public float velocidad = 2;
    public List<GameObject >obstaculos;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<21; i++)
        {

            cols.Add(Instantiate(Mapa, new Vector2(-10+ i, -3), quaternion.identity)) ;

        }

        obstaculos.Add(Instantiate(zom01, new Vector2(-14, -2), quaternion.identity)) ;


    }

    // Update is called once per frame
    void Update()
    {
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.021f, 0) * Time.deltaTime;
        
        
        for(int i=0; i<cols.Count; i++)
        {
            if(cols[i].transform.position.x <=-10)
            {
                cols[i].transform.position = new Vector3(10, -3, 0);

            }

            cols[i].transform.position = cols[i].transform.position + new Vector3(-1, 0, 0)*Time.deltaTime * velocidad;

        }
        for(int i=0; i<obstaculos.Count; i++)
        {
            if(obstaculos[i].transform.position.x <=-10)
            {
                
                obstaculos[i].transform.position = new Vector3(10, -3, 0);

            }

            obstaculos[i].transform.position = obstaculos[i].transform.position + new Vector3(-1, 0, 0)*Time.deltaTime * velocidad;

        }


        
    }
}
