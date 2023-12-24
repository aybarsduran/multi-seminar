using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayActivation : MonoBehaviour
{
   

    private PhotonView photonView;
    private void Start()
    {
        GameObject topParent = GetTopParent(gameObject);
        photonView = topParent.GetComponent<PhotonView>();
        if (photonView != null && photonView.IsMine)
        {
            this.GetComponent<Renderer>().enabled = false;
            Debug.Log("Start: Setting object inactive for local player");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Board") )
        {
            this.GetComponent<Renderer>().enabled = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Board"))
        {
            this.GetComponent<Renderer>().enabled = true;

            //Debug.Log("staying");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Board") )
        {
            this.GetComponent<Renderer>().enabled = false;

            //Debug.Log("exit");

        }
    }
    GameObject GetTopParent(GameObject childObject)
    {
        Transform parent = childObject.transform;

        // Loop through the hierarchy until there is no parent
        while (parent.parent != null)
        {
            parent = parent.parent;
        }

        // The 'parent' variable now contains the top-level parent (root) object
        return parent.gameObject;
    }

}
