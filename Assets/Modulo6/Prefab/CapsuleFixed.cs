using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleFixed : MonoBehaviour
{
    public GameObject PrefabCapsula;
<<<<<<< HEAD
    public bool Boolean = false;
    private Renderer objectRenderer;
    bool variable1;
    bool variable2;
    int valor2;
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
    }

    //private void FixedUpdate()
    //{
    //    GameObject tempGameObject = Instantiate<GameObject>(PrefabCapsula);
    //    Color c = new Color(Random.value, Random.value, Random.value);
    //    tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    //}
=======
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCapsula);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
>>>>>>> 62ba05f3943b80bd35fca531fec524aaff621cc9
}
