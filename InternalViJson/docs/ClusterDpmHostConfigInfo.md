# Vcenter.ViJson.OpenApi.Model.ClusterDpmHostConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the host.  Refers instance of *HostSystem*.  | 
**Enabled** | **bool** | Flag to indicate whether or not VirtualCenter is allowed to perform any power related operations or recommendations for this host.  If this flag is false, the host is effectively excluded from DPM service.  If no individual DPM specification exists for a host, this property defaults to true.  | [optional] 
**Behavior** | **DpmBehaviorEnum** | Specifies the particular DPM behavior for this host.  See also *ClusterDpmConfigInfo*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

