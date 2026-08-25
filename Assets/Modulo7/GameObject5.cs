using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject5 : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Capsule;

    private CubeUpdate ScriptCube;
    private CapsuleFixed ScriptCapsule;

    // Start is called before the first frame update
    void Start()
    {
        if (Cube != null) ScriptCube = Cube.GetComponent<CubeUpdate>();
        if (Capsule != null) ScriptCapsule = Capsule.GetComponent<CapsuleFixed>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScriptCube != null && ScriptCapsule != null)
        {
            bool boolCube = ScriptCube.Boolean;
            bool boolCapsule = ScriptCapsule.Boolean;

            if (boolCube && boolCapsule)
            {
                Debug.Log("El valor es verdadero");
            }
        }
    }
}