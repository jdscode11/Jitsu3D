using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Whitebelt : MonoBehaviour
{
    private Animator anim;
    
    private string axisNameX = "Horizontal";
    private string axisNameY = "Vertical";
    private bool openGuardUp;
    private bool downOpenGuard;
    private bool fullGuard;
    private bool sideGuardLeft;
    private bool sideGuardRight;
    private bool bridgeDown;
    private bool bridgeUpLeft;
    private bool bridgeUpMid;
    private bool bridgeUpRight;
    private bool triangleLeft;
    private bool triangleRight;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
        fullGuard= true;
        openGuardUp= false;
        downOpenGuard= false;
        bridgeDown= false;
        // sideGuardLeft= false;
        // sideGuardRight= false;
        // bridgeUpLeft= false;
        // bridgeUpMid= false;
        // bridgeUpRight= false;
        // triangleLeft= false;
        // triangleRight= false;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("LJX", (CrossPlatformInputManager.GetAxis(axisNameX)));
        anim.SetFloat("LJY", (CrossPlatformInputManager.GetAxis(axisNameY)));
        anim.SetFloat("RJX", (CrossPlatformInputManager.GetAxis(axisNameX)));
        anim.SetFloat("RJY", (CrossPlatformInputManager.GetAxis(axisNameY)));
        anim.SetBool("FullGuard", fullGuard);
        anim.SetBool("OpenGuardUp", openGuardUp);
        anim.SetBool("DownOpenGuard", downOpenGuard);
        anim.SetBool("BridgeDown", bridgeDown);
        // anim.SetBool("SideGuardLeft", sideGuardLeft);
        // anim.SetBool("SideGuardRight", sideGuardRight);
        // anim.SetBool("BridgeUpLeft", bridgeUpLeft);
        // anim.SetBool("BridgeUpMid", bridgeUpMid);
        // anim.SetBool("BridgeUpRight", bridgeUpRight);
        // anim.SetBool("TriangleLeft", triangleLeft);
        // anim.SetBool("TriangleRight", triangleRight);

        // if(CrossPlatformInputManager.GetAxis(axisNameY) > .50f || CrossPlatformInputManager.GetAxis(axisNameY) < -.50f)
        // {
                
        // }

        if(fullGuard && CrossPlatformInputManager.GetAxis(axisNameY) < -.50f)
        {
            fullGuard= false;
            openGuardUp= true;
            downOpenGuard= false;
            bridgeDown= false;
        }
        if(openGuardUp && CrossPlatformInputManager.GetAxis(axisNameY) > .50f)
        {
            fullGuard= true;
            openGuardUp= false;
            downOpenGuard= false;
            bridgeDown= false;

        }
        if(openGuardUp && CrossPlatformInputManager.GetAxis(axisNameY) < -.50f)
        {
            fullGuard= false;
            openGuardUp= false;
            downOpenGuard= true;
            bridgeDown= false;
        }
        if(downOpenGuard && CrossPlatformInputManager.GetAxis(axisNameY) > .50f)
        {
            fullGuard= false;
            openGuardUp= true;
            downOpenGuard= false;
            bridgeDown= false;
        }
        if(downOpenGuard && CrossPlatformInputManager.GetAxis(axisNameY) < -.50f)
        {
            fullGuard= false;
            openGuardUp= false;
            downOpenGuard= false;
            bridgeDown= true;
        }
        if(bridgeDown && CrossPlatformInputManager.GetAxis(axisNameY) > .50f)
        {
            fullGuard= false;
            openGuardUp= false;
            downOpenGuard= true;
            bridgeDown= false;
        }
    }
}
