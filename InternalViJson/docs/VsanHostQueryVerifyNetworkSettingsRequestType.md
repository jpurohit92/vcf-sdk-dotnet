# Vcenter.ViJson.OpenApi.Model.VsanHostQueryVerifyNetworkSettingsRequestType
The parameters of *HostVsanHealthSystem.VsanHostQueryVerifyNetworkSettings*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Peers** | **List&lt;string&gt;** | List of IP addresses of other hosts in the vSAN cluster. Used to perform connectivity checks.  | [optional] 
**ROBOStretchedClusterWitnesses** | **List&lt;string&gt;** | List of ROBO witness IPs. Used to info host that during the network connectivity check, the time out threshold should be different.  | [optional] 
**VMotionPeers** | **List&lt;string&gt;** | List of IP addresses of vMotion traffic enabled NICs excludes this host. Used to perform vMotion connectivity checks.  | [optional] 
**Spec** | [**VsanHealthQuerySpec**](VsanHealthQuerySpec.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

