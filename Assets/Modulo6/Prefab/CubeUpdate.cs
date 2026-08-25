<<<<<<< HEAD
using System;
=======
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUpdate : MonoBehaviour
{
    public GameObject PrefabCubo;
<<<<<<< HEAD
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;
    public bool Boolean = false;
    private Renderer objectRenderer;
    bool variable1;
    bool variable2;
    int valor1;
    enum SeleccionColor
    {
        blanco,
        negro
    }

    // A B    OR  AND
    // 1 1     1   1
    // 1 0     1   0
    // 0 1     1   0
    // 0 0     0   0
=======
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        listaDeCubos = new List<GameObject>();
        objectRenderer = GetComponent<Renderer>();
=======
        
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9
    }


    // Update is called once per frame
<<<<<<< HEAD
    void FixedUpdate()
    {
        Boolean = !Boolean;

        if (Boolean)
        {
            objectRenderer.material.color = Color.white;
        }
        else
        {
            objectRenderer.material.color = Color.black;
        }

        //if(variable1 && variable2)
        //{
        //    Debug.Log("La variable es verdadera");
        //}
        //else if (variable1 || variable2)
        //{
        //    Debug.Log("La variable es falsa");
        //}

        //string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo";
        //Debug.Log(resultado);

        //numCubos++;
        //GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        //tempGameObject.name = "CuboNumero" + numCubos;
        //Color c = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        //tempGameObject.transform.position = Random.insideUnitSphere;

        //listaDeCubos.Add(tempGameObject);
        //List<GameObject> objetosParaEliminar = new List<GameObject>();
        //foreach (GameObject go in listaDeCubos)
        //{
        //    float scale = go.transform.localScale.x;
        //    scale *= factorDeEscalamiento;
        //    go.transform.localScale = Vector3.one * scale;

        //    if (scale <= 0.1)
        //    {
        //        objetosParaEliminar.Add(go);
        //    }
        //}

        //foreach (GameObject go in objetosParaEliminar)
        //{
        //    listaDeCubos.Remove(go);
        //    Destroy(go);
        //}
=======
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9
    }
}
