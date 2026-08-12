# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCertificatesFilterSpec
The Vcenter.NamespaceManagement.Supervisors.Certificates.FilterSpec schema contains properties to filter certificates based on endpoint type.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Endpoint** | **string** | Filter certificates based on endpoint type.  Possible values:   - &#x60;VIP&#x60;: TLS endpoint on Kubernetes API servers when accessed via the load balancer.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Certificates.EndpointType*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the filter will be ignored. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

