using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

namespace SYGO.Network
{
    public class NetworkSessionHandler : NetworkManager
    {
        [Header("Players")]
        [SerializeField] private PlayerController _opponentPlayerController;
        [SerializeField] private PlayerController _currentPlayerController;

        public override void OnServerAddPlayer(NetworkConnectionToClient conn)
        {
            if (numPlayers > 2)
            {
                return;
            }


            /*
            Transform start = numPlayers == 0 ? leftRacketSpawn : rightRacketSpawn;
            GameObject player = Instantiate(playerPrefab, start.position, start.rotation);
            NetworkServer.AddPlayerForConnection(conn, player);

            // spawn ball if two players
            if (numPlayers == 2)
            {
                ball = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Ball"));
                NetworkServer.Spawn(ball);
            }
            */
        }

        public override void OnServerDisconnect(NetworkConnectionToClient conn)
        {
            base.OnServerDisconnect(conn);
        }
    }
}
