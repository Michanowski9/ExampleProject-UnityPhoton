using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyNetwork : MonoBehaviour {

    const string VERSION = "v0.1";

	void Start () {
        print("Connecting to server...");
        PhotonNetwork.ConnectUsingSettings(VERSION);
	}
    void OnConnectedToMaster()
    {
        print("Connected to Master.");
        PhotonNetwork.playerName = PlayerNetwork.Instance.PlayerName;

        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }
    void OnJoinedLobby()
    {
        print("Joined Lobby");
    }
}
