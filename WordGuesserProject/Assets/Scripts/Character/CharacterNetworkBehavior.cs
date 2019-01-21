using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterNetworkBehavior : NetworkBehaviour
{
    private void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<CharacterMovement>().enabled = true;
        }
    }
}
