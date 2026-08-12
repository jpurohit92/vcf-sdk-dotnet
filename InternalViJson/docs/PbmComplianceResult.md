# Vcenter.ViJson.OpenApi.Model.PbmComplianceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckTime** | **DateTime** | Time when the compliance was checked.  | 
**Entity** | [**PbmServerObjectRef**](PbmServerObjectRef.md) | Virtual machine or virtual disk for which compliance was checked.  | 
**Profile** | [**PbmProfileId**](PbmProfileId.md) | Requirement profile with which the compliance was checked.  | [optional] 
**ComplianceTaskStatus** | **string** | Status of the current running compliance operation.  If there is no compliance check operation triggered, this indicates the last compliance task status. &lt;code&gt;complianceTaskStatus&lt;/code&gt; is a string value that corresponds to one of the *PbmComplianceResultComplianceTaskStatus_enum* values.  | [optional] 
**ComplianceStatus** | **string** | Status of the compliance operation.  &lt;code&gt;complianceStatus&lt;/code&gt; is a string value that corresponds to one of the *PbmComplianceStatus_enum* values.  When you perform compliance checking on an entity whose associated profile contains more than one subprofile ( *PbmCapabilityProfile* . *PbmCapabilityProfile.constraints*), a compliant result for any one of the subprofiles will produce a compliant result for the operation.  | 
**Mismatch** | **bool** | Deprecated as of vSphere 2016, use *PbmComplianceStatus_enum* to know if a mismatch has occurred. If *PbmComplianceResult.complianceStatus* value is outOfDate, mismatch has occurred.  Set to true if there is a profile version mismatch between the Storage Profile Server and the storage provider.  If you receive a result that indicates a mismatch, you must use the vSphere API to update the profile associated with the virtual machine or virtual disk.  | 
**ViolatedPolicies** | [**List&lt;PbmCompliancePolicyStatus&gt;**](PbmCompliancePolicyStatus.md) | Values for capabilities that are known to be non-compliant with the specified constraints.  | [optional] 
**ErrorCause** | [**List&lt;MethodFault&gt;**](MethodFault.md) | This property is set if the compliance task fails with errors.  There can be more than one error since a policy containing multiple blobs can return multiple failures, one for each blob.  | [optional] 
**OperationalStatus** | [**PbmComplianceOperationalStatus**](PbmComplianceOperationalStatus.md) | Additional information on the effects of backend resources and operations on the storage object.  | [optional] 
**Info** | [**PbmExtendedElementDescription**](PbmExtendedElementDescription.md) | Informational localized messages provided by the VASA provider in addition to the &lt;code&gt;violatedPolicy&lt;/code&gt;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

