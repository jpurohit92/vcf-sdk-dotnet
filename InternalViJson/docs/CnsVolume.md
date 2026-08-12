# Vcenter.ViJson.OpenApi.Model.CnsVolume

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | Unique identifier and datastore information for the volume.  | 
**DatastoreUrl** | **string** | URL for datastore where the volume resides.     This is the URL from *Datastore.summary*.  | [optional] 
**Name** | **string** | Name of the volume.     Name size is limited to 80 bytes. CNS will not try to enforce uniqueness for volume name. Different container orchestrator clusters can create volumes with same name. Uniqueness within a container orchestrator cluster, if needed, should be enforced by the cluster orchestrator during volume creation.  | [optional] 
**VolumeType** | **string** | Type of this volume.     See *CnsVolumeType_enum* for all supported types and valid values for this field.  | [optional] 
**StoragePolicyId** | **string** | Storage policy associated with the container volume.  | [optional] 
**Metadata** | [**CnsVolumeMetadata**](CnsVolumeMetadata.md) | Metadata for this volume.  | [optional] 
**BackingObjectDetails** | [**CnsBackingObjectDetails**](CnsBackingObjectDetails.md) | Additional information about the backing object for this volume, specific to volume type.     See *CnsBackingObjectDetails* and its child-classes for more information.  | [optional] 
**ComplianceStatus** | **string** | Storage policy compliance status of the volume.     This will be one of the compliance status exposed by SPBM. See *PbmComplianceStatus_enum*.  | [optional] 
**DatastoreAccessibilityStatus** | **string** | Deprecated since vSphere 7.0 in favor of healthStatus.  Datastore accessibility status of the volume.     This will be one of the datastore accessibility status exposed by SPBM. See *PbmEntityHealthDatastoreAccessibilityStatus_enum*.  | [optional] 
**HealthStatus** | **string** | Health status of the volume.     This will be one of the health status exposed by SPBM. See *PbmEntityHealthStatus.healthStatus*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

