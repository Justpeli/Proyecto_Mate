using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipnormals : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        Mesh mesh = GetComponent<MeshFilter>().mesh; //Obtiene el componente mesh del objeto
        Vector3[] normals = mesh.normals; //Obtenemos las normales del componente
        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -1 * normals[i]; //invertimos las normales
        }

        mesh.normals = normals; //asignamos las nuevas normales al mesh

        for (int i = 0; i < mesh.subMeshCount; i++)
        {
            int[] tris = mesh.GetTriangles(i);

            //En el siguiente for se asignan las normales a los triangulos correspondientes de nuestro objeto
            for (int j = 0; j < tris.Length; j += 3)
            {
                int temp = tris[j];
                tris[j] = tris[j + 1];
                tris[j + 1] = temp;
            }

            mesh.SetTriangles(tris, i);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}