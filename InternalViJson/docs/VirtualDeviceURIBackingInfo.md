# Vcenter.ViJson.OpenApi.Model.VirtualDeviceURIBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceURI** | **string** | Identifies the local host or a system on the network, depending on the value of &lt;code&gt;*VirtualDeviceURIBackingInfo.direction*&lt;/code&gt;. - If you use the virtual machine as a server, the URI identifies   the host on which the virtual machine runs. In this case,   the host name part of the URI should be empty, or it should   specify the address of the local host. - If you use the virtual machine as a client, the URI identifies   the remote system on the network.  | 
**Direction** | **string** | The direction of the connection.  For possible values see *VirtualDeviceURIBackingOptionDirection_enum*  | 
**ProxyURI** | **string** | Identifies a proxy service that provides network access to the &lt;code&gt;*VirtualDeviceURIBackingInfo.serviceURI*&lt;/code&gt;.  If you specify a proxy URI, the virtual machine initiates a connection with the proxy service and forwards the *VirtualDeviceURIBackingInfo.serviceURI* and *VirtualDeviceURIBackingInfo.direction* to the proxy.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

