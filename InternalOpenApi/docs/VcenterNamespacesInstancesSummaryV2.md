# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesSummaryV2
The Vcenter.Namespaces.Instances.SummaryV2 schema contains the basic information about the namespace on a Supervisor.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supervisor** | **string** | Identifier for the Supervisor hosting the namespace.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | 
**Namespace** | **string** | Identifier of the namespace.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. | 
**Description** | **string** | Description of the namespace.  This property was added in __vSphere API 7.0.0.0__. | 
**ConfigStatus** | **string** | Current setting for Vcenter.Namespaces.Instances.ConfigStatus.  Possible values:   - &#x60;CONFIGURING&#x60;: The configuration is being applied to the namespace.   - &#x60;REMOVING&#x60;: The configuration is being removed and namespace is being deleted.   - &#x60;RUNNING&#x60;: The namespace is configured correctly.   - &#x60;ERROR&#x60;: Failed to apply the configuration to the namespace, user intervention needed.   For more information see: *Vcenter.Namespaces.Instances.ConfigStatus*.  This property was added in __vSphere API 7.0.0.0__. | 
**Stats** | [**VcenterNamespacesInstancesStats**](VcenterNamespacesInstancesStats.md) | Basic runtime statistics for the namespace.  This property was added in __vSphere API 7.0.0.0__. | 
**SelfServiceNamespace** | **bool** | Flag to indicate the self service namespace.  This property was added in __vSphere API 7.0.2.00100__.  If missing or &#x60;null&#x60;, the namespace is not marked as self service namespace. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

