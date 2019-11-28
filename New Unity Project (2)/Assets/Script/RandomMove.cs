using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{


    public Transform target;
    public Vector3 direction;
    public float velocity;
    public float default_velocity;
    float timeSpan;
    float checkTime;
    public Vector3 default_direction;
    public Animator t_anim;

    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 2.0f;


        // 자동으로 움직일 방향 벡터
        default_direction.x = Random.Range(-0.5f, 0.5f);  // 랜덤범위 설정
        default_direction.z = Random.Range(-0.5f, 0.5f);
        // 가속도 지정 (추후 힘과 질량, 거리 등 계산해서 수정할 것)
        velocity = 0.4f;
        default_velocity = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {


        timeSpan += Time.deltaTime;  // 경과 시간을 계속 등록
        if (timeSpan > checkTime)  // 경과 시간이 특정 시간이 보다 커졋을 경우
        {
            default_direction.x = Random.Range(-1.0f, 1.0f);
            default_direction.z = Random.Range(-1.0f, 1.0f);
            timeSpan = 0;
        }



        // Player의 현재 위치를 받아오는 Object
        target = GameObject.Find("Glad_all_anim").transform;
        // Player와 객체 간의 거리 계산
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= 45.0f)
        {
            t_anim.SetTrigger("run");
            MoveToTarget();
            // 일정 거리안에 있다가 다시 멀어졌을 때, 일정거리안에 있었던 player의 방향으로 움직임
            default_direction = direction;
            this.transform.position = new Vector3(transform.position.x + (default_direction.x * default_velocity),
                                                   transform.position.y,
                                                   transform.position.z + (default_direction.z * default_velocity)
                                                   );
            Vector3 relativePos = target.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = rotation;
        }
        // 일정거리 밖에 있을 시, 속도 초기화하고 해당 방향으로 무빙 
        else
        {
            t_anim.SetTrigger("run");
            velocity = 0.0f;
            this.transform.position = new Vector3(transform.position.x + (default_direction.x * default_velocity),
                                                   transform.position.y,
                                                   transform.position.z + (default_direction.z * default_velocity)
                                                   );
            Vector3 relativePos = transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = rotation;

        }
    }

    public void MoveToTarget()
    {
        t_anim.SetTrigger("run");
        // Player의 위치와 이 객체의 위치를 빼고 단위 벡터화 한다.
        direction = (target.position - transform.position).normalized;
        // 초가 아닌 한 프레임으로 가속도 계산하여 속도 증가
        velocity = (velocity * Time.deltaTime);
        // 해당 방향으로 무빙
        this.transform.position = new Vector3(transform.position.x + (direction.x * velocity),
                                              transform.position.y,
                                              transform.position.z + (direction.z * velocity)
                                                  );
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;

    }
}