# Vcenter.ViJson.OpenApi.Model.VsanStorageComplianceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckTime** | **DateTime** | Time when the compliance was checked.  | [optional] 
**Profile** | **string** | Requirement profile with which the compliance was checked.  | [optional] 
**ObjectUUID** | **string** | Requirement vSAN object with which the compliance was checked.  | [optional] 
**ComplianceStatus** | **string** | Status of the compliance operation.  See also *VsanStorageComplianceStatus_enum*.  | 
**Mismatch** | **bool** | True if there is a profile version mismatch between the Storage Profile Server and the storage provider.  If you receive a result that indicates a mismatch, you must use the vSphere API to update the profile associated with the virtual machine or virtual disk.  | 
**ViolatedPolicies** | [**List&lt;VsanStoragePolicyStatus&gt;**](VsanStoragePolicyStatus.md) | Values for capabilities that are known to be non-compliant with the specified constraints.  | [optional] 
**OperationalStatus** | [**VsanStorageOperationalStatus**](VsanStorageOperationalStatus.md) | Additional information on the effects of backend resources and operations on the storage object.  | [optional] 
**ObjPolicyGenerationId** | **string** | The actual object policy generation ID indicating if the object policy is out of date against the SPBM policy  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

