using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    /*void Awake()//게임 오브젝트 생성할 때 최초 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인 했습니다.");
    }
    void Start()//업데이트 시작 직전, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    void FixedUpdate()
        //물리 연산 업데이트,1초에 여러번 작동
        //고정된 실행 주기로 cpu를 많이 사용
    {
        Debug.Log("이동~");
    }
    void Update()//게임 로직 업데이트
        //컴푸터에 따라 실행주기가 다름
        //60frame
    {
        Debug.Log("몬스터 사냥!");
    }
    void LateUpdate()//모든 업데이트 끝난 후
    {
        Debug.Log("경험치 획득.");
    }
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다");
    }
    void OnDestroy()//오브젝트가 삭제될 때
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }*/
    void Update()
    {
        if (Input.anyKeyDown)//아무 입력을 최로로 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        /*키를 계속 누르고 있으면 true
           if (Input.anyKey)
               Debug.Log("플레이어가 아무 키를 누르고 있습니다.");*/
        if (Input.GetKeyDown(KeyCode.Return))//Enter=Return, ESC=Escape
            Debug.Log("아이템을 구입하였습니다.");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        //마우스 입력(0==왼쪽,1==오른쪽)
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("미사일 발사!");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("미사일 모으는 중...");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("슈퍼 미사일 발사!!");
        }
    }
}
