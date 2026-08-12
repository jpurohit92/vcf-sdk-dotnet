# Vcenter.ViJson.OpenApi.Model.VsanNetworkConfigPnicSpeedInconsistencyIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Host on which the vmknic exists  Refers instance of *HostSystem*.  | 
**VswitchName** | **string** | Standard virtual switch name, in case of VMware Standard Switch (VSS).  | [optional] 
**Vds** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Distributed Switch, if in-use.  Refers instance of *DistributedVirtualSwitch*.  | [optional] 
**SpeedsMb** | **List&lt;long&gt;** | Bit rates (speed) of the links, in Mbit/s.  This list only contains each present speed once. Links without any speed indication (e.g. links that are down) are not considered in the list. As there is an issue, there must be at least two members in this list.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

