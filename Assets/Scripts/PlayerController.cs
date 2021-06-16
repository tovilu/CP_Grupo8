using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private JugadorControles _input;
    private Vector2 _movement;
    private float _jump;

    private Animator anim;

    private bool andar = false;

    private const float Speed = 0.5f;
    void Awake()
    {
        _input = new JugadorControles();
    }

    void onEnable()
    {
        _input.Enable();
    }

    void onDisable()
    {
        _input.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        onEnable();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement = _input.Player.Movement.ReadValue<Vector2>();
        _jump = _input.Player.Jump.ReadValue<float>();
        anim.SetBool("andar", andar); 
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(_movement.x, _jump, _movement.y) * Speed);
        if (_movement.x != 0 || _movement.y != 0)
            andar = true;
        else
            andar = false;
    }
}
