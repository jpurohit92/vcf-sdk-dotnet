# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsMetricsRemoteEndpointsSummary
The Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpoints.Summary schema provides an overview of the remote endpoint configured for a Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteEndpoint** | **string** | The immutable identifier of a remote endpoint generated when a remote endpoint is registered with a Supervisor.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.metrics.RemoteEndpoint&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.metrics.RemoteEndpoint&#x60;. | 
**Name** | **string** | A display name to be used for the given remote endpoint.  This property was added in __vSphere API 9.0.0.0__. | 
**RemoteEndpointType** | **string** | Describes the type of remote endpoint.  Possible values:   - &#x60;HTTP&#x60;: Indicates HTTP/HTTPS based remote endpoint.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpointType*.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

