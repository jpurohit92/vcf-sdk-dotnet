# Vcenter.Automation.OpenApi.Model.VcenterNamespacesUserInstancesSummary
The Vcenter.Namespaces.User.Instances.Summary schema contains information about a namespace that user is authorized to access.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Namespace** | **string** | Identifier of the namespace.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. | 
**MasterHost** | **string** | IP address or FQDN of the API endpoint for the given namespace.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

