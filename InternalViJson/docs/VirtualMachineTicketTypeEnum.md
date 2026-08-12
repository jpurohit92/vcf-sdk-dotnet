# Vcenter.ViJson.OpenApi.Model.VirtualMachineTicketTypeEnum
The virtual machine ticket type.  Possible values: - `mks`:       Deprecated as of vSphere API 8.0. Use *webmks* instead.      Remote mouse-keyboard-screen ticket. - `device`:       Deprecated as of vSphere 8.0 API. Use *webRemoteDevice*   instead.      Remote device ticket. - `guestControl`:       Deprecated as of vSphere 6.6.3 API. Use   *GuestOperationsManager* instead.      Guest operation ticket. - `webmks`: Mouse-keyboard-screen over WebSocket ticket.      MKS protocol is VNC (a.k.a. RFB) protocol with   VMware extensions; the protocol gracefully degrades   to standard VNC if extensions are not available.   wss://{Ticket.host}/ticket/{Ticket.ticket} - `guestIntegrity`: Guest Integrity over WebSocket ticket.      This ticket grants the client read-only access to guest integrity   messages and alerts. - `webRemoteDevice`: Remote device over WebSocket ticket. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

