# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsMetricsRemoteEndpointsInfo
The Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpoints.Info schema details about the parameters used for configuring the Supervisor to send metrics to a remote endpoint.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A display name to be used for the given remote endpoint.  This property was added in __vSphere API 9.0.0.0__. | 
**Interval** | **long** | The frequency, in seconds, at which the Supervisor sends metrics to the remote endpoint.  This property was added in __vSphere API 9.0.0.0__. | 
**RemoteEndpointType** | **string** | Describes the type of remote endpoint.  Possible values:   - &#x60;HTTP&#x60;: Indicates HTTP/HTTPS based remote endpoint.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpointType*.  This property was added in __vSphere API 9.0.0.0__. | 
**HttpRemoteEndpoint** | [**VcenterNamespaceManagementSupervisorsMetricsHttpRemoteEndpointInfo**](VcenterNamespaceManagementSupervisorsMetricsHttpRemoteEndpointInfo.md) | Defines the HTTP or HTTPS remote endpoint configuration for Supervisor to send metrics.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of remote_endpoint_type is *Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpointType.HTTP*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

