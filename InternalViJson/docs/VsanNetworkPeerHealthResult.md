# Vcenter.ViJson.OpenApi.Model.VsanNetworkPeerHealthResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Peer** | **string** | IP address of the peer host used for testing network health.  A peer host may have multiple and this one may not be the &#39;primary&#39;.  | [optional] 
**PeerHostname** | **string** | Indicates the host which the IP &#39;peer&#39; belongs to  | [optional] 
**PeerVmknicName** | **string** | Indicates the vmknic which the IP &#39;peer&#39; is bound to  | [optional] 
**SmallPingTestSuccessPct** | **int** | Percentage of small ping packets that were successfully exchanged.  | [optional] 
**LargePingTestSuccessPct** | **int** | Percentage of large ping packets that were successfully exchanged.  | [optional] 
**MaxLatencyUs** | **long** | Maximum roundtrip latency in microseconds  | [optional] 
**OnSameIpSubnet** | **bool** | Whether or not the peer IP address is on the same IP subnet as the local host.  This is a pure configuration check based on local IP and subnet mask. See ping tests for real information about connectivity.  | [optional] 
**SourceVmknicName** | **string** | indicates which vmknic on local system the network ping check was using.  | [optional] 
**ConnectivityHealthState** | **string** | Indicates connectivity state with peer.  See also *VsanPeerHostConnectivityHealthState_enum*.  | [optional] 
**MissingHeartBeatCount** | **int** | Heartbeat missing counter for the connectivity check of vSAN client network.  The range for values for missingHeartBeatCount is between 0 to 10, where 10 means vmknic connection is down. This value is only meaningful when vSAN MAX client network is enabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

