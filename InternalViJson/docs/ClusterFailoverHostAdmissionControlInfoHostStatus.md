# Vcenter.ViJson.OpenApi.Model.ClusterFailoverHostAdmissionControlInfoHostStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The failover host.  Refers instance of *HostSystem*.  | 
**Status** | **ManagedEntityStatusEnum** | The status of the failover host.  The status is green for a connected host with no vSphere HA errors and no virtual machines running on it. The status is yellow for a connected host with no vSphere HA errors and some virtual machines running on it. The status red for a disconnected or not responding host, a host that is in maintenance or standby mode or that has a vSphere HA error on it.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

