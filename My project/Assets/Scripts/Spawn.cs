using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public List<Material> a;
    public GameObject quad;
    public GameObject planet;
    public int random_index;
    private int randomname;
    public int x;
    public Material Meme;
    public Material black;
    public Material blue;
    public Material red;
    public Material yellow;
    void Start()
    {
        spawnObjects();
        planet.gameObject.SetActive(false);
    }

    public void spawnObjects()
    {
        destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY, screenZ;
        Vector3 pos;
        Material random;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            screenZ = Random.Range(c.bounds.min.z, c.bounds.max.z);
            pos = new Vector3(screenX, screenY, screenZ);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            
            
            /* x = Random.Range(1, 5);
             switch (x)
             {
                 case 1:
                     toSpawn.GetComponent<Renderer>().material = yellow;
                     break;
                 case 2:
                     toSpawn.GetComponent<Renderer>().material = Meme;
                     break;
              
                 case 3 :
                     toSpawn.GetComponent<Renderer>().material = red;
                     break;
              
                 case 4:
                     toSpawn.GetComponent<Renderer>().material = blue;
                     break;
                 case 5:
                     toSpawn.GetComponent<Renderer>().material = black;
                     break;
             }
 */

        }
    }
    private void destroyObjects()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawn"))
        {
            Destroy(o);
        }
    }

    /*void randomtexture()
    {
        GameObject mesh;
        for (int i = 0; i < numberToSpawn; i++)
        {
            random_index = Random.Range(0, spawnPool.Count);
            mesh = spawnPool[random_index];
           


        }
    }
*/
}