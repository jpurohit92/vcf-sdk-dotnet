# Vcenter.ViJson.OpenApi.Model.VsanComplianceDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectUUID** | **string** | Requirement vSAN object with which the compliance was checked.  | 
**ComplianceStatus** | **string** | Status of the compliance check operation.  See also *VsanComplianceStatus_enum*.  | 
**ObjectHealth** | **int** | Value for object health state.  | 
**ViolatedPolicies** | [**List&lt;VsanPolicyStatus&gt;**](VsanPolicyStatus.md) | Values for capabilities that are known to be non-compliant with the specified constraints.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

