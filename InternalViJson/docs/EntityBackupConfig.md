# Vcenter.ViJson.OpenApi.Model.EntityBackupConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | Type of the exported entity (*DistributedVirtualSwitchManager.DVSManagerExportEntity_Task*).  See *EntityType_enum* for valid values.  | 
**ConfigBlob** | **byte[]** | Opaque blob that contains the configuration of the entity.  | 
**Key** | **string** | Unique identifier of the exported entity or the entity to be restored through an import operation. - If you are importing a virtual distributed switch and the import type is   *applyToEntitySpecified*,   set the &lt;code&gt;key&lt;/code&gt; to   *DistributedVirtualSwitch*.*DistributedVirtualSwitch.uuid*. - If you are importing a virtual distributed portgroup and the import type is   *applyToEntitySpecified*,   set the &lt;code&gt;key&lt;/code&gt; to   *DistributedVirtualPortgroup*.*DistributedVirtualPortgroup.key*.    The Server ignores the key value when the import operation creates a new entity.  | [optional] 
**Name** | **string** | Name of the exported entity or the entity to be restored with the backup configuration.  If you are importing an entity and the import type is *applyToEntitySpecified*, the Server will use this value to rename the existing entity.  | [optional] 
**Container** | [**ManagedObjectReference**](ManagedObjectReference.md) | Container for this entity.  If *EntityBackupConfig.entityType* is \&quot;distributedVirtualSwitch\&quot;, the container type is *Folder*. If *EntityBackupConfig.entityType* is \&quot;distributedVirtualPortgroup\&quot;, the container type is *DistributedVirtualSwitch*.  Refers instance of *ManagedEntity*.  | [optional] 
**ConfigVersion** | **string** | Configuration version.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

