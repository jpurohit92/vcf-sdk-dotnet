# Vcenter.ViJson.OpenApi.Model.CnsKubernetesQueryFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeIds** | [**List&lt;CnsVolumeId&gt;**](CnsVolumeId.md) | Volume identifiers to be queried.     A maximum of 1000 volume ids can be provided.  | [optional] 
**Names** | **List&lt;string&gt;** | Volume names to be queried.     Currently only full string match will be supported. No regex or substring matching will be done.  | [optional] 
**ContainerClusterIds** | **List&lt;string&gt;** | Container orchestrator cluster identifiers.  | [optional] 
**StoragePolicyId** | **string** | Storage policy id associated with volume.     This will be matched to the actual storage policy attached with the volume.  | [optional] 
**Datastores** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Volumes located on this Datastore will be returned.  Refers instances of *Datastore*.  | [optional] 
**Labels** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Labels to be matched for this volume.     Label key and value should be an exact match. All volumes that match any of the labels will be returned in the result.  | [optional] 
**ComplianceStatus** | **string** | Storage policy compliance status of the volume.     This must be one of the compliance status exposed by SPBM. See *VsanComplianceStatus_enum*.  | [optional] 
**DatastoreAccessibilityStatus** | **string** | Deprecated since vSphere 7.0 in favor of healthStatus.  Datastore accessibility status of the volume.     This must be one of the datastore accessibility status exposed by SPBM. See *PbmEntityHealthDatastoreAccessibilityStatus_enum*.  | [optional] 
**Cursor** | [**CnsCursor**](CnsCursor.md) | Cursor object, pointing to desired range of results.  | [optional] 
**HealthStatus** | **string** | Health status of the volume.     This will be one of the health status exposed by SPBM. See *PbmEntityHealthStatus.healthStatus*.  | [optional] 
**Namespaces** | **List&lt;string&gt;** | Associated Kubernetes namespaces.  | [optional] 
**PodNames** | **List&lt;string&gt;** | Associated Pod names.  | [optional] 
**PvcNames** | **List&lt;string&gt;** | Associated PVC names.  | [optional] 
**PvNames** | **List&lt;string&gt;** | Associated PV names.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

