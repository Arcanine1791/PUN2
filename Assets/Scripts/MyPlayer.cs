using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;
[RequireComponent (typeof (CharacterController))]
[RequireComponent (typeof (CapsuleCollider))]
public class MyPlayer : MonoBehaviour
{
PhotonView view;
public float speed;
   CharacterController cc;
  public Vector3 playerVelocity;
private void Start() {
     cc=  GetComponent<CharacterController>();
     view=GetComponent<PhotonView>();
}
    private void Update() {
        
if(view.IsMine)
{
        Vector3 moveInputs=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        cc.Move(moveInputs*Time.deltaTime*speed);
    }
    }
}