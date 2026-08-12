# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemOvfSummary
The Vcenter.Ovf.LibraryItem.OvfSummary schema defines the result of the filter operation. See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*. The properties in the schema describe parameterizable information in the OVF descriptor, with respect to a deployment target, for the deploy operation. See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Default name for the virtual machine or virtual appliance.  If missing or &#x60;null&#x60;, the OVF descriptor did not specify a name. | [optional] 
**Annotation** | **string** | Default annotation for the virtual machine or virtual appliance.  If missing or &#x60;null&#x60;, the OVF descriptor did not specify an annotation. | [optional] 
**Eulas** | **List&lt;string&gt;** | End User License Agreements specified in the OVF descriptor. All end user license agreements must be accepted in order for the deploy operation to succeed. See *Vcenter.Ovf.LibraryItem.ResourcePoolDeploymentSpec.accept_all_EULA*. | 
**Networks** | **List&lt;string&gt;** | Section identifiers for sections of type ovf:NetworkSection in the OVF descriptor. These identifiers can be used as keys in *Vcenter.Ovf.LibraryItem.ResourcePoolDeploymentSpec.network_mappings*.  If missing or &#x60;null&#x60;, the OVF descriptor did not specify any networks. | [optional] 
**StorageGroups** | **List&lt;string&gt;** | Section identifiers for sections of type vmw:StorageGroupSection in the OVF descriptor. These identifiers can be used as keys in *Vcenter.Ovf.LibraryItem.ResourcePoolDeploymentSpec.storage_mappings*.  If missing or &#x60;null&#x60;, the OVF descriptor did not specify any storage groups. | [optional] 
**AdditionalParams** | [**List&lt;VcenterOvfOvfParams&gt;**](VcenterOvfOvfParams.md) | Additional OVF parameters which can be specified for the deployment target. These OVF parameters can be inspected, optionally modified, and used as values in *Vcenter.Ovf.LibraryItem.ResourcePoolDeploymentSpec.additional_parameters* for the deploy operation.  If missing or &#x60;null&#x60;, the OVF descriptor does not require addtional parameters or does not have additional parameters suitable for the deployment target.  When clients pass a value of this schema as a parameter, the property must contain all the properties defined in *Vcenter.Ovf.OvfParams*. When operations return a value of this schema as a response, the property will contain all the properties defined in *Vcenter.Ovf.OvfParams*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

