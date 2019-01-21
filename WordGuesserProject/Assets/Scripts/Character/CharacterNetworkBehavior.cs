using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterNetworkBehavior : NetworkBehaviour
{
    [SyncVar]
    public string name = "player";

    private void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<CharacterMovement>().enabled = true;
        }
    }

    void OnGUI()
    {
        if (isLocalPlayer)
        {
            name = GUI.TextField(new Rect(25, Screen.height - 40, 100, 30), name);
            if (GUI.Button(new Rect(130, Screen.height - 40, 100, 30), "UPDATE"))
            {
                CmdNameChanged(name);
            }
        }
    }

    private void Update()
    {
        this.GetComponentInChildren<TextMesh>().text = name;
    }

    [Command]
    public void CmdNameChanged(string inputName)
    {
        name = inputName;
    }
}
