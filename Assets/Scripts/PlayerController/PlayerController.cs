using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [Header("Player Config")]
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _speed, _jumpForce;
    [SerializeField] Rigidbody _playerRigidbody;
    [SerializeField] Animator _animator;

    [SerializeField] GameObject _player;
    Vector2 startTouchPosition;
    Vector2 endTouchPosition;
    

    MoveController _moveController;


    private void Awake()
    {
        _moveController = new MoveController();
    }


    private void Update()
    {

        
        HavadaMi();
        Hareket();
    }

    private void FixedUpdate()
    {
        Run();

    }


    void Run()
    {


        _player.transform.position += new Vector3(0, 0, _speed * Time.deltaTime);
        _animator.SetFloat("__isRun",1);

    }

    void Jump()
    {
        if (_playerTransform.position.y < 0.0085)
        {
            _moveController.Jump(_playerRigidbody, _jumpForce);
        }
        

        

    }
    void Down()
    {
        _player.transform.position = new Vector3(_player.transform.position.x, 0.026f, _player.transform.position.z);
        _moveController.Jump(_playerRigidbody, -160);

    }
    void Left()
    {
        _player.transform.position = new Vector3(-2.6f, _player.transform.position.y, _player.transform.position.z);
        
    }
    void Right()
    {
        _player.transform.position = new Vector3(2.3f, _player.transform.position.y, _player.transform.position.z);
        
        
    }

    void HavadaMi()
    {
        if (_playerTransform.position.y > 0.0085 )
        {
            _animator.SetBool("__isJump", true);

        }
        else
        {
            _animator.SetBool("__isJump", false);

        }
    }


    void Hareket()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if (endTouchPosition.x < startTouchPosition.x-150f)
            {
                Left();
            }

            if (endTouchPosition.x > startTouchPosition.x+150f)
            {
                Right();
            }
            if (endTouchPosition.y < startTouchPosition.y-150f)
            {
                Down();
            }
            if (endTouchPosition.y > startTouchPosition.y+150f)
            {
                Jump();
            }
        }

    }

}
