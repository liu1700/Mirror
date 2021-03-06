# Change Log

## Version 1.5 -- 2019-Mar-01

- Added: **Migration Tool** to (mostly) automate conversion from UNet
- Added: Full support for WebSockets and WebSocketsSecure to replace UNet LLAPI
- Added: Transport Multiplexer - allows the use of multiple concurrent transports
- Added: Lobby Manager and Lobby Player with example game
- Added: Configurable Server Tickrate in NetworkManager
- Added: New virtual OnClientChangeScene fires right before SceneManager.LoadSceneAsync is executed
- Added: Unit tests for Weaver
- Fixed: Garbage allocations removed from a lot of things (more work to do, we know)
- Fixed: NetworkProximityChecker now uses OverlapSphereNonAlloc and OverlapCircleNonAlloc
- Fixed: SyncVar hook not firing when clients joined
- Fixed: NetworkManager no longer assumes it's on Scene(0) in Build Settings
- Fixed: NetworkAnimator no longer lmited to 6 variables
- Fixed: TelepathyTransport delivering messages when disabled
- Removed: SceneAttribute.cs (merged to CustomAttributes.cs)
- Removed: NetworkClient.allClients (Use NetworkClient.singleton instead)
- Removed: NetworkServer.hostId and NetworkConnection.hostId (holdovers from LLAPI)
- Removed: NetworkConnection.isConnected (NetworkConnection is always connected)
- Removed: Transport.GetConnectionInfo (Use ServerGetClientAddress instead)
- Changed: Minimum Unity version: **2018.3.6**


## Version 1.4 -- 2019-Feb-01

- Added: HelpURL attirbutes to components
- Added: Automatic targetFramerate for headless builds
- Added: ByteMessage to Messages class
- Fixed: Connectiing state can be cancelled properly
- Fixed: NetworkTransformBase interpolation applied to client's own object
- Fixed: Objects are spawned with correct rotation
- Fixed: SceneId assignment
- Fixed: Changed syncInterval wasn't saved...it is now
- Fixed: Additive Scene loading
- Changed: **Mirror is now full source** -- no more DLL's
- Changed: **Transports are now components** -- TCP, UDP, WebGL, Steam
- Changed: Transport class now dispatches Unity Events
- Changed: NetworkServer.SendToClientOfPlayer uses NetworkIdentity now
- Changed: NetworkServer.SendToObservers uses NetworkIdentity parameter now
- Changed: NetworkServer.SendToReady uses NetworkIdentity now
- Changed: NetworkServer.DestroyPlayerForConnection uses NetworkIdentity.spawned now
- Changed: NetworkConnection.Dispose uses NetworkIdentity.spawned now
- Changed: NetworkReader.ReadTransform uses NetworkIdentity.spawned now
- Changed: NetworkTransform reimplemented -- physics removed, code simplified
- Removed: NetworkClient.hostPort (port is handled at Transport level)
- Removed: NetworkServer.FindLocalObject (Use NetworkIdentity.spawned\[netId\] instead)
- Removed: ClientScene.FindLocalObject (Use NetworkIdentity.spawned\[netId\] instead)
