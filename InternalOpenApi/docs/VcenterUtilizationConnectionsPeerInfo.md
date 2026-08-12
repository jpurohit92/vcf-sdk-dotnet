# Vcenter.Automation.OpenApi.Model.VcenterUtilizationConnectionsPeerInfo
The Vcenter.Utilization.Connections.PeerInfo schema defines information about a remote client that is connected to a server.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The IP address of the remote client of the server.  This property was added in __vSphere API 9.1.0.0__. | 
**Port** | **long** | The port of the remote client of the server.  This property was added in __vSphere API 9.1.0.0__. | 
**TcpState** | **string** | The TCP state of the connection.  Possible values:   - &#x60;ESTABLISHED&#x60;: The connection is fully established and data can be exchanged.   - &#x60;SYN_SENT&#x60;: The client sent a SYN packet to the server and is waiting for the SYN-ACK reply.   - &#x60;SYN_RECV&#x60;: The server received the SYN packet from the client and sent a SYN-ACK packet back to the client.   - &#x60;FIN_WAIT1&#x60;: One side of the connection sent a FIN packet to the other side to initiate the termination of the connection.   - &#x60;FIN_WAIT2&#x60;: The side that sent the FIN packet received an ACK from the other side.   - &#x60;TIME_WAIT&#x60;: One side waits for a period of time to ensure the other side has received the final ACK before transitioning to CLOSE.   - &#x60;CLOSE&#x60;: The connection on this side is completely terminated, with no further data transfer possible, indicating that all cleanup has been completed.   - &#x60;CLOSE_WAIT&#x60;: One side of the connection has received a FIN from its peer and is waiting for the local application to close the connection by sending its own FIN.   - &#x60;LAST_ACK&#x60;: The side of the connection that sent the final FIN packet waits for the final ACK.   - &#x60;LISTEN&#x60;: The server socket is passively waiting for incoming connection requests from clients.   - &#x60;CLOSING&#x60;: Both endpoints have simultaneously sent FIN packets and each is waiting for the final ACK from the other to confirm complete connection termination.   For more information see: *Vcenter.Utilization.Connections.TcpState*.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

