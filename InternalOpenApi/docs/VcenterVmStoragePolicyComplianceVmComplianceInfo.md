# Vcenter.Automation.OpenApi.Model.VcenterVmStoragePolicyComplianceVmComplianceInfo
The Vcenter.Vm.Storage.Policy.Compliance.VmComplianceInfo schema contains information about storage policy compliance associated with a virtual machine.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of the compliance operation.  Possible values:   - &#x60;COMPLIANT&#x60;: Entity is in compliance.   - &#x60;NON_COMPLIANT&#x60;: Entity is out of compliance.   - &#x60;UNKNOWN_COMPLIANCE&#x60;: Compliance status of the entity is not known.   - &#x60;NOT_APPLICABLE&#x60;: Compliance computation is not applicable for this entity because it does not have any storage requirements that apply to the datastore on which it is placed.   - &#x60;OUT_OF_DATE&#x60;: The Compliance status becomes out-of-date when the profile associated with the entity is edited but not applied. The compliance status remains out-of-date until the edited policy is applied to the entity.   For more information see: *Vcenter.Vm.Storage.Policy.Compliance.Status*.  This property was added in __vSphere API 6.7__. | 
**CheckTime** | **DateTime** | Date and time of the most recent compliance check.  This property was added in __vSphere API 6.7__. | 
**Policy** | **string** | Identifier of the storage policy associated with the virtual machine.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; SPBM is unable to retrieve or determine the associated policy, *Vcenter.Vm.Storage.Policy.Compliance.VmComplianceInfo.failure_cause* is set in such cases.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. | [optional] 
**FailureCause** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | The exception that caused the compliance check to fail. There can be more than one cause, since a policy can contain capabilities from multiple providers. If empty, it implies no failures while retrieving compliance.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

