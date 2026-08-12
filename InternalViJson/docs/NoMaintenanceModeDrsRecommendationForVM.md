# Vcenter.ViJson.OpenApi.Model.NoMaintenanceModeDrsRecommendationForVM
This event records that DRS did not recommend a migration for a powered on virtual machine, even though its host is going into maintenance mode.  DRS may not be able to recommend a migration for a virtual machine for reasons, include but not limited to: - No other connected host is compatible with this virtual machine. - None of the other compatible hosts have sufficient resources   to satisfy the reservation requirements of this virtual machine. - Moving to any other host would violate a DRS rule. For example, all   other compatible hosts have some incompatible virtual machines   running. - DRS is disabled on this virtual machine. - This virtual machine was still in the process of migrating   into the host going into maintenance mode and was not   considered by DRS. - This virtual machine was in the process of migrating to another   host when the host tried to enter maintenance mode. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Template** | **bool** | Indicates whether or not the virtual machine is marked as a template.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

