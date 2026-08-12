# Vcenter.ViJson.OpenApi.Model.VsanEsaConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoragePoolSpecs** | [**List&lt;VsanAddStoragePoolDiskSpec&gt;**](VsanAddStoragePoolDiskSpec.md) | vSAN storage pool disk specification for manual disk claim.  Throws fault if vSAN ESA is not enabled or if any errors occur during storage pool disk claim operation. Refer to *VsanAddStoragePoolDiskSpec*  | [optional] 
**HclDiskClaimEnabled** | **bool** | Whether the HCLDiskClaim setting is enabled for the cluster.  Set hclDiskClaimEnabled to True/False, to enable/disable HCL disk claim feature on vSAN ESA cluster. Throws fault if 1\\. HclDiskClaim is being enabled and storagePoolSpec is being specified for manual disk claim. 2\\. If vSAN ESA is not enabled or being enabled. 3\\. If vSAN ESA is being disabled and hclDiskClaim setting is being enabled in the input spec.  | [optional] 
**DatastoreDefaultPolicySelectionConfig** | [**VsanDatastoreDefaultPolicySelectionConfig**](VsanDatastoreDefaultPolicySelectionConfig.md) | vSAN datastore default policy selection configurations.  Only available for vSAN ESA  | [optional] 
**DiskConfiguration** | [**VsanEsaDiskConfiguration**](VsanEsaDiskConfiguration.md) | Attribute to specify disk configuration for vSAN ESA prescriptive disk claim feature.  vSAN will automatically claim disks according to the prescribed configuration on all hosts in the cluster. Throws fault if 1\\. vSAN ESA is not enabled or being disabled. 2\\. If HCL aware disk claim configuration is enabled or being enabled. 3\\. If storagePoolSpecs is also specified. 4\\. Any other faults that occur while performing disk claim operation on the cluster. Refer to *VsanEsaDiskConfiguration*  | [optional] 
**AutoRAIDConfig** | [**VsanAutoRAIDConfig**](VsanAutoRAIDConfig.md) | vSAN auto RAID configuration.  | [optional] 
**DeleteStoragePoolDiskSpec** | [**VsanDeleteStoragePoolDiskSpec**](VsanDeleteStoragePoolDiskSpec.md) | vSAN storage pool disk remove specification for manual disk removal.  Throws fault if vSAN ESA is not enabled or if any errors occur during storage pool disk removal operation. Refer to *VsanDeleteStoragePoolDiskSpec*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

