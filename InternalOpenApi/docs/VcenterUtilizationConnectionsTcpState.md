# Vcenter.Automation.OpenApi.Model.VcenterUtilizationConnectionsTcpState
The Vcenter.Utilization.Connections.TcpState enumerated type represents the possible states of a TCP connection as defined by Section 3.3.2 of Transmission Control Protocol [RFC 9293].  Possible values:   - `ESTABLISHED`: The connection is fully established and data can be exchanged.   - `SYN_SENT`: The client sent a SYN packet to the server and is waiting for the SYN-ACK reply.   - `SYN_RECV`: The server received the SYN packet from the client and sent a SYN-ACK packet back to the client.   - `FIN_WAIT1`: One side of the connection sent a FIN packet to the other side to initiate the termination of the connection.   - `FIN_WAIT2`: The side that sent the FIN packet received an ACK from the other side.   - `TIME_WAIT`: One side waits for a period of time to ensure the other side has received the final ACK before transitioning to CLOSE.   - `CLOSE`: The connection on this side is completely terminated, with no further data transfer possible, indicating that all cleanup has been completed.   - `CLOSE_WAIT`: One side of the connection has received a FIN from its peer and is waiting for the local application to close the connection by sending its own FIN.   - `LAST_ACK`: The side of the connection that sent the final FIN packet waits for the final ACK.   - `LISTEN`: The server socket is passively waiting for incoming connection requests from clients.   - `CLOSING`: Both endpoints have simultaneously sent FIN packets and each is waiting for the final ACK from the other to confirm complete connection termination.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

