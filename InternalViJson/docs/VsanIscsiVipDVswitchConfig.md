# Vcenter.ViJson.OpenApi.Model.VsanIscsiVipDVswitchConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortGroup** | [**ManagedObjectReference**](ManagedObjectReference.md) | The port group moref for distributed vSwitch on which the virtual IP vmkernal adapter is created on.  It should be set for enabling virtual IP. If the port group is removed after enablement, then it will be unset in the virtual IP query result.  Refers instance of *DistributedVirtualPortgroup*.  | [optional] 
**DvsUuid** | **string** | The dvs uuid for distributed vSwitch on which the virtual IP vmkernal adapter is created on.  Leave it unset for enabling virtual IP. It will be set for querying virtual IP configurations.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

