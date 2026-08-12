# Vcenter.ViJson.OpenApi.Model.StorageDrsAutomationConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SpaceLoadBalanceAutomationMode** | **string** | Specifies the behavior of Storage DRS when it generates recommendations for correcting space load imbalance in a datastore cluster.  See *StorageDrsPodConfigInfo*. If specified, this option overrides the datastore cluster level automation behavior defined in the *StorageDrsPodConfigInfo*.  | [optional] 
**IoLoadBalanceAutomationMode** | **string** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Specifies the behavior of Storage DRS when it generates recommendations for correcting I/O load imbalance in a datastore cluster.  See *StorageDrsPodConfigInfo*. If specified, this option overrides the datastore cluster level automation behavior defined in the *StorageDrsPodConfigInfo*.  | [optional] 
**RuleEnforcementAutomationMode** | **string** | Specifies the behavior of Storage DRS when it generates recommendations for correcting affinity rule violations in a datastore cluster.  See *StorageDrsPodConfigInfoBehavior_enum*. If specified, this option overrides the datastore cluster level automation behavior defined in the *StorageDrsPodConfigInfo* for recommendations aimed at fixing rule violations.  | [optional] 
**PolicyEnforcementAutomationMode** | **string** | Specifies the behavior of Storage DRS when it generates recommendations for correcting storage and Vm policy violations in a datastore cluster.  See *StorageDrsPodConfigInfoBehavior_enum*. If specified, this option overrides the datastore cluster level automation behavior defined in the *StorageDrsPodConfigInfo* for recommendations aimed at fixing storage policy violations.  | [optional] 
**VmEvacuationAutomationMode** | **string** | Specifies the behavior of Storage DRS when it generates recommendations for datastore evacuations in a datastore cluster.  See *StorageDrsPodConfigInfoBehavior_enum*. If specified, this option overrides the datastore cluster level automation behavior defined in the *StorageDrsPodConfigInfo* for recommendations aimed at evacuating Vms from a datastore.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

