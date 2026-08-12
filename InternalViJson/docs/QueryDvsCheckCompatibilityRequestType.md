# Vcenter.ViJson.OpenApi.Model.QueryDvsCheckCompatibilityRequestType
The parameters of *DistributedVirtualSwitchManager.QueryDvsCheckCompatibility*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostContainer** | [**DistributedVirtualSwitchManagerHostContainer**](DistributedVirtualSwitchManagerHostContainer.md) | The container of hosts on which we check the compatibility. This container can be a datacenter, folder, or computeResource. We can also include all the hosts in the hierarchy with container as root of the tree.  | 
**DvsProductSpec** | [**DistributedVirtualSwitchManagerDvsProductSpec**](DistributedVirtualSwitchManagerDvsProductSpec.md) | The productSpec of a DistributedVirtualSwitch. If not set, it is assumed to be the default one used for DistributedVirtualSwitch creation for current version.  | [optional] 
**HostFilterSpec** | [**List&lt;DistributedVirtualSwitchManagerHostDvsFilterSpec&gt;**](DistributedVirtualSwitchManagerHostDvsFilterSpec.md) | The hosts against which to check compatibility. This is a filterSpec and users can use this to specify all hosts in a container (datacenter, folder, or computeResource), an array of hosts, or hosts that might or might not be a DVS member.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

