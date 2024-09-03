using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class CustomNetworkManager : MonoBehaviour
{
    // NetworkManager를 참조하기 위한 변수
    private NetworkManager networkManager;

    // Start is called before the first frame update
    void Start()
    {
        // NetworkManager 컴포넌트를 가져옴
        networkManager = GetComponent<NetworkManager>();

        // 서버가 시작될 때 호출될 콜백 등록
        networkManager.OnServerStarted += OnServerStarted;

        // 클라이언트가 연결될 때 호출될 콜백 등록
        networkManager.OnClientConnectedCallback += OnClientConnected;

        // 서버를 시작
        StartServer();
    }

    // 서버를 시작하는 함수
    private void StartServer()
    {
        networkManager.StartServer();
    }

    // 서버가 시작되었을 때 호출될 함수
    private void OnServerStarted()
    {
        Debug.Log("서버가 시작되었습니다.");
    }

    // 클라이언트가 연결되었을 때 호출될 함수
    private void OnClientConnected(ulong clientId)
    {
        Debug.Log($"클라이언트가 연결되었습니다. Client ID: {clientId}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}