using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour {

    //public int tree_height;
    static public int tree_height;

    // Use this for initialization
    void Start()
    {
        tree_height = 0;
    }

    // Update is called once per frame
    void Update () 
    {

        //Debug.Log(tree_height);

        if(tree_height == 0)
        {
            if (this.gameObject.transform.localScale != new Vector3(1f, 1f, 1f))
                this.gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
        else if(tree_height == 1)
        {
            if (this.gameObject.transform.localScale != new Vector3(2f, 2f, 2f))
                this.gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);

        }
        else if(tree_height == 2)
        {
            if (this.gameObject.transform.localScale != new Vector3(3f, 3f, 3f))
                this.gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);

        }
        else if (tree_height == 3)
        {
            if (this.gameObject.transform.localScale != new Vector3(4f, 4f, 4f))
                this.gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);

        }




    }
}
