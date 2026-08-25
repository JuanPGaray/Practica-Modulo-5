using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAwake : MonoBehaviour
{
    public GameObject PrefabEsfera;
<<<<<<< HEAD
    public GameObject Cube;
    public GameObject Capsule;

    private CubeUpdate ScriptCube;
    private CapsuleFixed ScriptCapsule;

    //private void Awake()
    //{
    //    GameObject tempGameObject = Instantiate<GameObject>(PrefabEsfera);
    //    Color c = new Color(Random.value, Random.value, Random.value);
    //    tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    //}
=======

    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabEsfera);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9


    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        if (Cube != null) ScriptCube = Cube.GetComponent<CubeUpdate>();
        if (Capsule != null) ScriptCapsule = Capsule.GetComponent<CapsuleFixed>();
=======
        
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (ScriptCube != null && ScriptCapsule != null)
        {
            bool boolCube = ScriptCube.Boolean;
            bool boolCapsule = ScriptCapsule.Boolean;

            if (boolCube && boolCapsule)
            {
                Debug.Log("El valor es verdadero");
            }
        }
=======
        
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9
    }
}
