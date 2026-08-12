# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementZonesClusterCompatibilitiesCompatibilityMessage
The Vcenter.NamespaceManagement.Zones.ClusterCompatibilities.CompatibilityMessage schema contains information about the Compute Cluster Compute Resource's compatibility with a vSphere Zone.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | Type of the message.  Possible values:   - &#x60;WARNING&#x60;: Warning reason regarding compatibility. Warnings are informational and won&#39;t prevent a Cluster Compute Resource from being added to a vSphere Zone.   - &#x60;ERROR&#x60;: Error reason for a Cluster Compute Resource being incompatible with the vSphere Zone.   For more information see: *Vcenter.NamespaceManagement.Zones.ClusterCompatibilities.CompatibilityMessage.MessageSeverity*.  This property was added in __vSphere API 9.1.0.0__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the Cluster Compute Resources compatibility with the vSphere Zone.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

