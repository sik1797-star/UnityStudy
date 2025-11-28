using UnityEngine;

public class ActorManager : MonoBehaviour
{
   //게임오브젝트가 활성화될 때 가장 먼저 호출(한 번만) 
    private void Awake()
    {
        //Debug.Log("Awake");
    }

    //게임오브젝트가 활성활 될 때마다 호출
    private void OnEnable()
    {
        //Debug.Log("OnEnabl");
    }

    //게임오브젝트가 활성화될 때 단 한 번만 호출
    void Start()
    {
        //Debug.Log("Start");
        GameObject go = new GameObject("Actor");
        go.SetActive(false);
        Actor actor = go.AddComponent<Actor>();
        actor.enabled = false;
        actor.actorName = "Ashley";
        actor.actorType = "extra01";
        go.SetActive (true);
    }

    //게임오브젝트가 활성화되어 있는 동안 매프레임마다 한 번씩 호출
    void Update()
    {
        //Debug.Log("Update");
    }

    //게임오브젝트가 비활성화 될 때마다 호출
    private void OnDisable()
    {
        //Debug.Log("OnDisable");
    }
}
