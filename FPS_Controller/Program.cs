//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

/* FPS (ou Em Primeira Pessoa Shooter) é um tipo de jogo onde o personagem principal é controlado a partir de uma perspectiva em primeira pessoa.

Com controles habituais sendo W, A, S, D para andar, Mouse Look to look around, Space to jump, e Left Shift para correr, permitindo que o jogador se mova livremente ao redor do nível.

Neste post, vou mostrar como fazer um controlador FPS em Unity que vai lidar com a rotação da câmera e o movimento do jogador.

Passos
Para fazer um controlador FPS, siga os passos abaixo:

Crie um novo objeto de jogo (GameObject -> Crie Vazio) e nomeie-o como "FPSPlayer"
Crie uma nova cápsula (GameObject -> cápsula de > de objeto 3D) e mova-a para dentro do objeto "FPSPlayer"
Remova o componente Colisor de Cápsulas da Cápsula e altere sua posição para (0, 1, 0)
Mova a câmera principal dentro do objeto "FPSPlayer" e altere sua posição para (0, 1.64, 0)*/

//Codigo.. Atenção.: Descomentar quando importado para dentro da Unity

//[RequireComponent(typeof(CharacterController))]

//public class SC_FPSController : MonoBehaviour
//{
//    public float walkingSpeed = 7.5f;
//    public float runningSpeed = 11.5f;
//    public float jumpSpeed = 8.0f;
//    public float gravity = 20.0f;
//    public Camera playerCamera;
//    public float lookSpeed = 2.0f;
//    public float lookXLimit = 45.0f;

//    CharacterController characterController;
//    Vector3 moveDirection = Vector3.zero;
//    float rotationX = 0;

//    [HideInInspector]
//    public bool canMove = true;

//    void Start()
//    {
//        characterController = GetComponent<CharacterController>();

//        // Lock cursor
//        Cursor.lockState = CursorLockMode.Locked;
//        Cursor.visible = false;
//    }

//    void Update()
//    {
//        // We are grounded, so recalculate move direction based on axes
//        Vector3 forward = transform.TransformDirection(Vector3.forward);
//        Vector3 right = transform.TransformDirection(Vector3.right);
//        // Press Left Shift to run
//        bool isRunning = Input.GetKey(KeyCode.LeftShift);
//        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
//        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;
//        float movementDirectionY = moveDirection.y;
//        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

//        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
//        {
//            moveDirection.y = jumpSpeed;
//        }
//        else
//        {
//            moveDirection.y = movementDirectionY;
//        }

//        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
//        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
//        // as an acceleration (ms^-2)
//        if (!characterController.isGrounded)
//        {
//            moveDirection.y -= gravity * Time.deltaTime;
//        }

//        // Move the controller
//        characterController.Move(moveDirection * Time.deltaTime);

//        // Player and Camera rotation
//        if (canMove)
//        {
//            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
//            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
//            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
//            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
//        }
//    }
//}