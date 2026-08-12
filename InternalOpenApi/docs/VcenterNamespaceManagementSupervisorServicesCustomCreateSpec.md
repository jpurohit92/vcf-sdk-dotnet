# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesCustomCreateSpec
The Vcenter.NamespaceManagement.SupervisorServices.CustomCreateSpec schema provides a specification required to create a Supervisor Service with a version from a plain Kubernetes YAML format.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorService** | **string** | The identifier of the Supervisor Service. This has DNS_LABEL restrictions as specified in [](https://tools.ietf.org/html/rfc1123). This must be an alphanumeric (a-z and 0-9) string and with maximum length of 63 characters and with the &#39;-&#39; character allowed anywhere except the first or last character. This identifier must be unique across all Namespaces in this vCenter server. Additionally, the ID &#39;namespaces&#39; is reserved and must not be used.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. | 
**DisplayName** | **string** | A human readable name of the Supervisor Service.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | A human readable description of the Supervisor Service.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the Supervisor Service description will be empty. | [optional] 
**VersionSpec** | [**VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpec**](VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpec.md) | Supervisor service version specification that provides the service definition for one Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

