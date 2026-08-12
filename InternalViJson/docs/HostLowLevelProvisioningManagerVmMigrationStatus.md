# Vcenter.ViJson.OpenApi.Model.HostLowLevelProvisioningManagerVmMigrationStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MigrationId** | **long** | Unique identifier for this operation, currently it&#39;s unique within one virtual center instance.  | 
**Type** | **string** | Manner in which the migration process is performed.  The set of possible values is described in *HostVMotionManagerVMotionType_enum*.  | 
**Source** | **bool** | Whether the virtual machine is the source of the migration.  For disk only migration, the value is always true.  | 
**ConsideredSuccessful** | **bool** | Whether the operation is considered successful.  A migration operation is considered successful if its switch over phase has completed successfully.  More specifically, for an in-progress migration, it is considered successful if it has had a successful switch over, otherwise it is considered unsuccessful. Likewise, the status of a completed migration operation is also based on the switch over completion status.  The difference between a completed vs. in-progress migration with the same consideredSuccessful property is that in the former case the server is able to complete the clean up process thus leaves nothing for the recovery process to clean up.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

