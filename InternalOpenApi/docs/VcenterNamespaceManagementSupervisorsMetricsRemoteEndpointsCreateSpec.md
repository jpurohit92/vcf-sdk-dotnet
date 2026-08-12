# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsMetricsRemoteEndpointsCreateSpec
The Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpoints.CreateSpec schema is used to configure a new remote endpoint with the Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A display name to be used for the given remote endpoint.  This property was added in __vSphere API 9.0.0.0__. | 
**Interval** | **long** | The frequency, in seconds, at which the Supervisor sends metrics to the remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the frequency, will default to 60 seconds. | [optional] 
**RemoteEndpointType** | **string** | Describes the type of remote endpoint.  Possible values:   - &#x60;HTTP&#x60;: Indicates HTTP/HTTPS based remote endpoint.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpointType*.  This property was added in __vSphere API 9.0.0.0__. | 
**HttpRemoteEndpoint** | [**VcenterNamespaceManagementSupervisorsMetricsHttpRemoteEndpointCreateSpec**](VcenterNamespaceManagementSupervisorsMetricsHttpRemoteEndpointCreateSpec.md) | Defines the HTTP or HTTPS remote endpoint configuration for Supervisor to send metrics.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of remote_endpoint_type is *Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpointType.HTTP*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

